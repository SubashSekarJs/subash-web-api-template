using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subash.WebAPI.Service.Application.Features.ExamplesFeatures.Query.GetExamples
{
    public class GetExampleRequestHandler : IRequestHandler<GetExampleRequest, List<GetExampleResponse>>
    {
        public GetExampleRequestHandler()
        {
        }

        public async Task<List<GetExampleResponse>> Handle(GetExampleRequest request, CancellationToken cancellationToken)
        {
            List<GetExampleResponse> result = new List<GetExampleResponse>();

            return result;  
        }
    }
}
