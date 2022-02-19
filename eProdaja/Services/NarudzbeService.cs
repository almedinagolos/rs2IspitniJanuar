using AutoMapper;
using eProdaja.Database;
using eProdaja.Filters;
using eProdaja.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Narudzbe = eProdaja.Model.Narudzbe;

namespace eProdaja.Services
{
    public class NarudzbeService : INarudzbeService
    {
        public eProdajaContext Context { get; set; }
        protected readonly IMapper _mapper;

        public NarudzbeService(eProdajaContext context, IMapper mapper)
        {
            Context = context;
            _mapper = mapper;
        }

        public IList<Model.Narudzbe> GetAll(NarudzbeSearchRequest search)
        {
            var query = Context.Narudzbes.AsQueryable();

            if (search?.ProizvodiId != null)
            {
                query = query.Where(x => x.NarudzbaStavkes.Count(y=>y.ProizvodId == search.ProizvodiId) > 0);
            }
            if (search?.DatumOd != null)
            {
                query = query.Where(x => x.Datum >= search.DatumOd);
            }
            if (search?.DatumDo != null)
            {
                query = query.Where(x => x.Datum <= search.DatumDo);
            }

            if (search?.MinIznosNarudzbe != null)
            {
                query = query.Where(x => x.Izlazis.Sum(y=>y.IznosSaPdv) >= search.MinIznosNarudzbe);
            }
            var entities = query.Include(x=>x.Kupac).Include(x=>x.Izlazis).Include(x=>x.NarudzbaStavkes).ToList();

            return _mapper.Map<IList<Model.Narudzbe>>(entities);
        }
    }
}
