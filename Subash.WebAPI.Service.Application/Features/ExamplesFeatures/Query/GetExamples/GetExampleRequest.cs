using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace Subash.WebAPI.Service.Application.Features.ExamplesFeatures.Query.GetExamples
{
    public class GetExampleRequest : IRequest<List<GetExampleResponse>>
    {
    }
}
