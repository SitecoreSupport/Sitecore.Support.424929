using Sitecore.Data.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sitecore.Support.Forms.Mvc.Models.Fields
{
  public class DropListField : Sitecore.Forms.Mvc.Models.Fields.DropListField
  {
    // Methods
    public DropListField(Item item) : base(item)
    {
    }

    // Properties
    public override object Value
    {
      get
      {
        return base.Value;
      }
      set
      {
        if (value is List<string>)
        {
          if (((List<string>)value).Count > 0)
          {
            base.Value = ((List<string>)value)[0];
          }
        }
        else
        {
          base.Value = value;
        }
      }
    }
  }
}