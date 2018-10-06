using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using ClientProgramLib.Data;
using ClientProgramLib.Models;

namespace ClientProgram.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<ClientContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ClientContext context) { }
    }
}
