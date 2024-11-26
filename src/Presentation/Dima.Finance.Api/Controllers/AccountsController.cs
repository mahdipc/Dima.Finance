using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Dima.Finance.Api.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/v1/[controller]")]
    public class AccountsController : ApiControllerBase
    {
        private readonly IMediator _mediator;

        public AccountsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<PaginatedList<AccountBriefDto>>> GetAccounts([FromQuery] GetAccountsWithPaginationQuery query)
        {
            return await _mediator.Send(query);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<AccountDetailDto>> GetAccount(Guid id)
        {
            return await _mediator.Send(new GetAccountDetailQuery { Id = id });
        }

        // More endpoints...
    }
}
