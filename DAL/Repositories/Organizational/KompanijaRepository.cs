﻿using System;
using System.Linq;
using model = DAL.Models;
using domain = LearnByPractice.Domain.Organizational;

namespace DAL.Repositories.Organizational
{

   public class KompanijaRepository : RepositoryBase
    {
         public KompanijaRepository()
        {
        }
        public domain.KompanijaCollection GetAll()
        {
            model.LearnByPracticeDataContext context = CreateContext();
            IQueryable<model.Organizacija> query = context.Organizacijas;
            domain.KompanijaCollection result = new domain.KompanijaCollection();
            foreach (model.Organizacija modelObject in query)
            {
                domain.Kompanija domainObject = new domain.Kompanija();
                domainObject.Id = modelObject.ID;
                domainObject.Ime = modelObject.Ime;
                domainObject.Adresa = modelObject.Adresa;
                domainObject.KontaktTelefon = modelObject.Kontakt_Telefon;
                domainObject.VebStrana = modelObject.Veb_Strana;
                domainObject.vidOrganizacija.Ime = modelObject.Vid_Organizacija.Ime;
                result.Add(domainObject);
            }

            return result;
        }

        public domain.Kompanija Get(int id)
        {
            using (model.LearnByPracticeDataContext context = CreateContext())
            {
                IQueryable<model.Organizacija> query = context.Organizacijas.Where(c => c.ID == id);

                domain.Kompanija domainObject = ToDomain(query.Single());

                return domainObject;
            }
        }


        public domain.Kompanija Insert(domain.Kompanija domainObject)
        {
            using (model.LearnByPracticeDataContext context = CreateContext())
            {
                model.Organizacija modelObject = new model.Organizacija();
                modelObject.Ime = domainObject.Ime;
                modelObject.Adresa = domainObject.Adresa;
                modelObject.Kontakt_Telefon = domainObject.KontaktTelefon;
                modelObject.Veb_Strana = domainObject.VebStrana;
                modelObject.Vid_Organizacija.Ime = domainObject.vidOrganizacija.Ime;
                context.Organizacijas.InsertOnSubmit(modelObject);
                context.SubmitChanges();
                domain.Kompanija result = ToDomain(modelObject);

                return result;
                

            }
        }

        private domain.Kompanija ToDomain(model.Organizacija modelObject)
        {
            throw new NotImplementedException();
        }

    }
    }

