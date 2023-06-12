﻿using MediatR;
using Titan.DataProvider.Domain.Shared;

namespace Titan.DataProvider.Application.Abstractions.Application.Messaging;

public interface IQuery<TResponse> : IRequest<Result<TResponse>>
{
}
