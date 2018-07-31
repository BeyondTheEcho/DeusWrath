using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord;

namespace DeusWrath
{
    public class InfoModule : ModuleBase<SocketCommandContext>
    {
        [Command("!ping", RunMode = RunMode.Async)]
        [Summary("A Simple Test")]
        [RequireContext(ContextType.Guild)]
        public async Task Ping()
        {
            // To get a users message contents
            // await Context.Message.Content

            await Context.Channel.SendMessageAsync("Pong!");



        }
    }
}
