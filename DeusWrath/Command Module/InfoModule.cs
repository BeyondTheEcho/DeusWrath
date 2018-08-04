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
        [Command("D20" , RunMode = RunMode.Async)]
        [Alias("Dice", "RollDice")]
        [Summary("Roll D20")]
        [RequireContext(ContextType.Guild)]
        public async Task RollD20()
        {
            // To get a users message contents
            // await Context.Message.Content

            Random rnd = new Random();
            int dice = rnd.Next(0, 20);
            await Context.Channel.SendMessageAsync("You roll a 20 sided die and it lands on " + dice.ToString());

        }

        [Command("Elgeem", RunMode = RunMode.Async)]
        [Summary("Msg for Elgeem")]
        [RequireContext(ContextType.Guild)]
        public async Task Elgeem()
        {
            await Context.Channel.SendMessageAsync("I luv you Elgeem <3 Please take me back.");
        }

        [Command("Umbre", RunMode = RunMode.Async)]
        [Summary("Msg for Umbre")]
        [RequireContext(ContextType.Guild)]
        public async Task Umbre()
        {
            await Context.Channel.SendMessageAsync("Have Faith!");
        }

        [Command("TZ", RunMode = RunMode.Async)]
        [Summary("Returns current time in many TZs")]
        [RequireContext(ContextType.Guild)]
        public async Task CurrentTimeZones()
        {
            // Return current time in UTC, EST, PST and other relevent TZs
        }
    }
}
