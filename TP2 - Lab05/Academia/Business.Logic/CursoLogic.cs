using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database;

namespace Business.Logic {
  
    public class CursoLogic: BusinessLogic {

        CursoAdapter cursoData;

        public CursoLogic() {
            cursoData = new CursoAdapter();
        }

        public List<Curso> GetAll() {
            return cursoData.GetAll();
        }

        public Curso GetOne(int id) {
            return cursoData.GetOne(id);
        }

        public void Save(Curso curso) {
            cursoData.Save(curso);
        }
    }
}
