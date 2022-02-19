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
using PregledNarudzbi = eProdaja.Model.PregledNarudzbi;

namespace eProdaja.Services
{
    public class PregledNarudzbiService : IPregledNarudzbiService
    {
        public eProdajaContext Context { get; set; }
        protected readonly IMapper _mapper;

        public PregledNarudzbiService(eProdajaContext context, IMapper mapper)
        {
            Context = context;
            _mapper = mapper;
        }

        public List<Model.PregledNarudzbi> GetAll(PregledNarudzbiSearchRequest search)
        {
            var query = Context.PregledNarudzbi.AsQueryable();

            if (search.KupacId != null)
            {
                query = query.Where(x => x.KupciId == search.KupacId);
            }
      
            var entities = query.Include(x => x.Kupci).ToList();

            var list = _mapper.Map<List<Model.PregledNarudzbi>>(entities);
            foreach (var item in list)
            {
                item.ProsjecniPromet = Context.PregledNarudzbi.Where(x=>x.KupciId == item.KupciId).Average(y=> (decimal?) y.IznosNarudzbe) ?? 0;
            }
            return list;
        }

        public Model.PregledNarudzbi Insert(PregledNarudzbiInsertRequest request)
        {
            var entity = _mapper.Map<Database.PregledNarudzbi>(request);
            Context.Add(entity);
          
            Context.SaveChanges();

            return _mapper.Map<Model.PregledNarudzbi>(entity);

        }
    }
}
