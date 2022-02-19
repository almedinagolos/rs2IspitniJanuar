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
using Kupci = eProdaja.Model.Kupci;

namespace eProdaja.Services
{
    public class KupciService : IKupciService
    {
        public eProdajaContext Context { get; set; }
        protected readonly IMapper _mapper;

        public KupciService(eProdajaContext context, IMapper mapper)
        {
            Context = context;
            _mapper = mapper;
        }


        public IList<Kupci> GetAll(KupciSearchRequest search)
        {
            var query = Context.Kupcis.AsQueryable();

            if (search?.KupacId != null)
            {
                query = query.Where(x => x.KupacId == search.KupacId);
            }

          
            var entities = query.ToList();
          

            return _mapper.Map<IList<Model.Kupci>>(entities);

        }
    }
}
