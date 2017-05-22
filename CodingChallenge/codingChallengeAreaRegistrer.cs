using System.Web.Mvc;

namespace CodingChallenge
{
    public class CodingChallengeAreaRegistrer : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "CodingChallenge";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "CodingChallenge_default",
                "CodingChallenge/{controller}/{action}",
                new { action = "Index" });
        }
    }
}