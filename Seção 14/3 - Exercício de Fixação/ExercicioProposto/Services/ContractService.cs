using System;
using System.Collections.Generic;
using System.Text;
using ExercicioProposto.Entities;

namespace ExercicioProposto.Services
{
    class ContractService
    {
        private IOnlinePaymentService _onlinePaymentService;

        public ContractService(IOnlinePaymentService onlinePaymentService)
        {
            _onlinePaymentService = onlinePaymentService;
        }

        public void ProcessContract(Contract contract, int months)
        {
            double fee = contract.TotalValue / months;

            for (int i = 1; i <= months; i++)
            {
                double value = fee + _onlinePaymentService.Interest(fee, i);
                double totalValue = value + _onlinePaymentService.PaymentFee(value);

                DateTime dueDate = contract.Date.AddMonths(i);

                Installment installment = new Installment(dueDate, totalValue);

                contract.Installments.Add(installment);
            }
        }
    }
}
