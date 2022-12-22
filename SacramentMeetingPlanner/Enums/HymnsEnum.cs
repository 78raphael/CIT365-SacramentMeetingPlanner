using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace SacramentMeetingPlanner.Enums
{
    public enum HymnsEnum
    {
        [Display (Name = "#1 The Morning Breaks")]
        Mornings_Breaks = 1,
        [Display(Name = "#2 The Spirit of God")]
        Spirit_of_God = 2 ,
        [Display(Name = "#3 Now Let Us Rejoice")]
        Now_Let_Us_Rejoice = 3,
        [Display(Name = "#4 Truth Eternal")]
        Truth_Eternal = 4,
        [Display(Name = "#5 High on the Mountain Top")]
        Mountain_Top = 5,
        [Display(Name = "#6 Redeemer of Israel")]
        Redeemer_Israel = 6,
        [Display(Name = "#7 Israel, Israel, God is Calling")]
        God_Calling = 7,
        [Display(Name = "#8 Awake and Arise")]
        Awake_Arise = 8,
        [Display(Name = "#9 Come, Rejoice")]
        Come_Rejoice = 9,
        [Display(Name = "#10 Come, Sing to the Lord")]
        Sing_Loed = 10
    }
}
