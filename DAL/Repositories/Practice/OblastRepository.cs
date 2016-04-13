﻿using System;
using System.Linq;


namespace DAL.Repositories.Practice
{

    using model = DAL.Models;
    using domain = LearnByPractice.Domain.Practice;

    class OblastRepository : RepositoryBase
    {
            public OblastRepository()
        {
        }
        public domain.OblastCollection GetAll()
        {
            model.LearnByPracticeDataContext context = CreateContext();
            IQueryable<model.Oblast> query = context.Oblasts;
            domain.OblastCollection result = new domain.OblastCollection();
            foreach (model.Oblast modelObject in query)
            {
                domain.Oblast domainObject = new domain.Oblast();
                domainObject.Id = modelObject.ID;
                domainObject.Ime = modelObject.Ime;
              result.Add(domainObject);
            }

            return result;
        }

        public domain.Oblast Get(int id)
        {
            using (model.LearnByPracticeDataContext context = CreateContext())
            {
                IQueryable<model.Oblast> query = context.Oblasts.Where(c => c.ID == id);

                domain.Oblast domainObject = ToDomain(query.Single());

                return domainObject;
            }
        }


        public domain.Oblast Insert(domain.Oblast domainObject)
        {
            using (model.LearnByPracticeDataContext context = CreateContext())
            {
                model.Oblast modelObject = new model.Oblast();
                domainObject.Ime = modelObject.Ime;
                context.Oblasts.InsertOnSubmit(modelObject);
                context.SubmitChanges();
                domain.Oblast result = ToDomain(modelObject);

                return result;

            }
        }

        private domain.Oblast ToDomain(model.Oblast modelObject)
        {
            throw new NotImplementedException();
        }
    }
        }
    
