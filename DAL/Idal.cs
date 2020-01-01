using System;
using System.Collections.Generic;
using System.Text;
using BE;

namespace DAL
{
    interface Idal
    {
        void addRequest(GuestRequest request);
        void updateRequest(GuestRequest request);

        void addHostingUnit(HostingUnit unit);
        void deleteHostingUnit(HostingUnit unit);
        void updateHostingUnit(HostingUnit unit);

        void addOrder(Order order);
        void updateOrder(Order order);

        List<HostingUnit> getAllUnits();
        List<GuestRequest> getAllGuestRequest();
        List<Order> getAllOrder();

        List<BankBranch> getAllBranches();
    }
}