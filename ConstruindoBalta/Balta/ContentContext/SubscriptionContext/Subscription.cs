using System;
using Balta.SharedContext;

namespace Balta.SubscriptionContext
{
    public class Subcription : Base
   {
       public Plan Plan { get; set; }
       
       public DateTime? EndDate { get; set; }

        //A Assinatura estará inativa se o dia Final for menor que o dia atual.
       public bool IsInactive => EndDate <= DateTime.Now;
   }
}