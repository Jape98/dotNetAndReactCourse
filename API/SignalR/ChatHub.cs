using Application.Comments;
using MediatR;
using Microsoft.AspNetCore.SignalR;

namespace API.SignalR
{
    public class ChatHub : Hub
    {
        private readonly IMediator mediator;
        public ChatHub(IMediator mediator)
        {
            this.mediator = mediator;
        }
        
        public async Task SendComment(Create.Command command)
        {
            var comment = await mediator.Send(command);

            await Clients.Group(command.ActivityId.ToString())
                .SendAsync("ReciveComment", comment.Value);
        }

        public override async Task OnConnectedAsync()
        {
            var httpContext = Context.GetHttpContext();
            var activityId = httpContext.Request.Query["activityId"];
            //add connection id to activityId group
            await Groups.AddToGroupAsync(Context.ConnectionId, activityId);
            //get list of comments from database
            var result = await mediator.Send(new List.Query{ActivityId = Guid.Parse(activityId)});
            //send list of comments from database
            await Clients.Caller.SendAsync("LoadComments", result.Value);
        }
    }
}