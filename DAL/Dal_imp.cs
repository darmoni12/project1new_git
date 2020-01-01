using System;
using System.Collections.Generic;
using System.Text;
using BE;
using DS;

namespace DAL
{
    public class Dal_imp : Idal
    {

        public void addHostingUnit(HostingUnit unit)
        {
           
            DataSource.hostingUnitsList.Add(unit);
        }

        public void addOrder(Order order)
        {
            DataSource.ordersList.Add(order);
        }

        public void addRequest(GuestRequest request)
        {
            DataSource.requestsList.Add(request);
        }

        public void deleteHostingUnit(HostingUnit unit)
        {
            DataSource.hostingUnitsList.Remove(unit);
        }

        public List<BankBranch> getAllBranches()
        {
            return new List<BankBranch>()
            {
               new BankBranch()
               {
                   BankName="rgh",BankNumber=54,BranchAddress="rsdf",BranchCity="wsfgd",BranchNumber=3422
               },
               new BankBranch()
               {
                   BranchNumber=54,BranchCity="sgsdbf",BranchAddress="sfg",BankNumber=987,BankName="dgs"
               },
               new BankBranch()
               {
                   BranchNumber=87,BranchCity="yjfgf",BranchAddress="sufhg",BankNumber=977,BankName="jyfs"
               },
                new BankBranch()
               {
                   BranchNumber=91,BranchCity="yt",BranchAddress="iuh",BankNumber=125,BankName="jhgs"
               }, new BankBranch()
               {
                   BranchNumber=84,BranchCity="drt",BranchAddress="bn",BankNumber=957,BankName="jhgfs"
               }
            };
        }

        public List<GuestRequest> getAllGuestRequest()
        {
            return new List<GuestRequest>(requestsList);/////
        }

        public List<Order> getAllOrder()
        {
            return new List<Order>(ordersList);////
        }

        public List<HostingUnit> getAllUnits()
        {
            return new List<HostingUnit>(hostingUnitsList);////
        }

        public void updateHostingUnit(HostingUnit unit)
        {
            throw new NotImplementedException();
        }

        public void updateOrder(Order order)
        {
            throw new NotImplementedException();
        }

        public void updateRequest(GuestRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
