using System.Threading.Tasks;
using Seger.Http.Generated;
using Newtonsoft.Json;

namespace Seger.Http.Generated
{
    public partial class ApiException<TResult>
    {
        public override string ToString()
        {
            if (Result is ValidationProblemDetails validationProblemDetails)
            {
                return validationProblemDetails.Detail;
            }

            return base.ToString();
        }

        public override string Message => ToString();
    }
}
