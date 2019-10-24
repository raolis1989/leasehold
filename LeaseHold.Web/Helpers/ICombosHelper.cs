using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace LeaseHold.Web.Helpers
{
    public interface ICombosHelper
    {
        IEnumerable<SelectListItem> GeTComboPropertyTypes();
    }
}