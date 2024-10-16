﻿using FluentResults;

namespace eAgenda.WebApi.Controllers
{
    public class ApiControllerBase : ControllerBase
    {
        protected IActionResult ProcessarResultado(Result result, object viewModel = null)
        {
            if (result.IsFailed)
                return BadRequest(result.Errors);

            return this.Ok(viewModel);
        }

        public override OkObjectResult Ok(object? dados)
        {
            return base.Ok(new
            {
                Sucesso = true,
                Dados = dados
            });
        }

        public override NotFoundObjectResult NotFound(object objetoComErros)
        {
            IList<IError> erros = (List<IError>)objetoComErros;

            return base.NotFound(new
            {
                Sucesso = false,
                Erros = erros.Select(x => x.Message)
            });
        }

        public override BadRequestObjectResult BadRequest(object objetoComErros)
        {
            IList<IError> erros = (List<IError>)objetoComErros;

            return base.BadRequest(new
            {
                Sucesso = false,
                Erros = erros.Select(x => x.Message)
            });
        }
    }
}