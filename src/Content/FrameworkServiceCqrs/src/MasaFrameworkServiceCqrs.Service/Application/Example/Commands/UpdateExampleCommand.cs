﻿namespace MasaFrameworkServiceCqrs.Service.Application.Example.Commands;

public record UpdateExampleCommand(Guid Id, ExampleCreateUpdateDto Dto) : Command
{
}
