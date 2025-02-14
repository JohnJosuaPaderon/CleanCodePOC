﻿using FluentValidation;
using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CleanCodePOC.Processes.Behaviors
{
    public class ProcessValidationBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse> 
        where TRequest : IRequest<TResponse>
    {
        private readonly IEnumerable<IValidator<TRequest>> _validators;

        public ProcessValidationBehavior(IEnumerable<IValidator<TRequest>> validators)
        {
            _validators = validators;
        }

        public async Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken, RequestHandlerDelegate<TResponse> next)
        {
            var failures = _validators
                    .Select(_ => _.Validate(request))
                    .SelectMany(_ => _.Errors)
                    .Where(_ => _ is not null)
                    .ToList();

            if (failures is not null && failures.Any())
            {
                throw new ValidationException(failures);
            }

            return await next();
        }
    }
}
