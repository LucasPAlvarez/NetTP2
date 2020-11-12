using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database;

namespace Business.Logic {
    public class PlanLogic: BusinessLogic {
        PlanAdapter planData = new PlanAdapter();

        public List<Plan> GetAll() {
            return planData.GetAll();
        }

        public Plan GetOne(int id) {
            return planData.GetOne(id);
        }

        public void Save(Plan plan) {
            planData.Save(plan);
        }
    }
}
