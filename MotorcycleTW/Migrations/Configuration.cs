namespace MotorcycleTW.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using MotorcycleTW.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<MotorcycleTW.Models.MotorcycleContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MotorcycleTW.Models.MotorcycleContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            context.Members.AddOrUpdate(
                x => x.m_id,
                new Members { m_id = 1, m_name = "���l��",m_adress="��鿤���������s�n��1401��43��", m_email="gash86726@gmail.com",m_password="gash0806449",m_status="1"},
                new Members { m_id = 2, m_name = "����", m_adress = "��鿤���������s�n��1401��44��", m_email = "gash5558@gmail.com", m_password = "gash09754295009", m_status = "1" },
                new Members { m_id = 3, m_name = "�\���Q", m_adress = "��鿤���������s�n��1401��45��", m_email = "gash884151@gmail.com", m_password = "gash99518", m_status = "1" }        
                );
        }
    }
}
