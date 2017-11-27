using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrintCG_24062016.API.Enums
{
    public enum StatusTag
    {
        Pending, InfoReceived, InTransit, OutForDelivery, AttemptFail, Delivered, Exception, Expired
    }
}
