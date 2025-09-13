using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders.Shared.Interfaces;

public interface IEntityWithName
{
    String Name { get; set; }
}