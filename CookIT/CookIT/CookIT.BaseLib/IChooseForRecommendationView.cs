using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookIT.BaseLib
{
    public interface IChooseForRecommendationView
    {
        bool ShowModalView();

        string Type { get; }
        string Ingredient { get; }
    }
}
