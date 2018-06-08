using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IvanAgencyService.BindingModel;
using IvanAgencyService.ViewModel;

namespace IvanAgencyService.Interfaces
{
    public interface IMain
    {
        List<OrderViewModel> GetList(int id);

        List<OrderViewModel> GetList();

        void CreateOrder(OrderBindingModel model);

        void PayOrder(OrderBindingModel model);

        OrderViewModel GetElement(int id);

        void BonusOrder(OrderBindingModel model);

        void UpdateOrder(OrderBindingModel model);


    }
}
