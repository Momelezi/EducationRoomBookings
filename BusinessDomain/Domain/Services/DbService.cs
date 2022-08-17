using BusinessDomain.Database;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessDomain.Domain.Dbservice
{
    public class DbService
    {
        protected BookingDBContext DB;

        public DbService()
        {
            if (DB == null)
            {
                try
                {
                    DB = new BookingDBContext();
                }
                catch
                {
                    throw;
                }
            }
        }

        public void Save()
        {
            try
            {
                DB.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        

        public Branch GetBranch(int branchId)
        {
            return DB.Branches
                .Where(x => x.BranchId == branchId)
                .Select(x => x).FirstOrDefault();
        }

        public List<Branch> AllBranches()
        {
            return DB.Branches
                .Select(x => x).ToList();
        }

        public List<Branch> AllActiveBranches()
        {
            return DB.Branches
                .Where(x => x.Active == true)
                .Select(x => x).ToList();
        }

        public Branch CreateBranch(Branch branch )
        {
           
           
       var b=     DB.Branches.Add(branch);
            Save();
            return b;   
        }

        public void SetBranchActive(int branchId, bool active)
        {
            var branch = GetBranch(branchId);
            branch.Active = active;
            Save();
        }

        public void Edit(Branch  branch)
        {

            Save();


        }
        
        }
    }
