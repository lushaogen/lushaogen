
using Microsoft.EntityFrameworkCore;
using System;
using System.Reflection;

namespace JHMESClient.Models
{
    public class JHDBContext : DbContext
    {
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserInfo> UserInfos { get; set; }
        public DbSet<UserGroups> UserGroup { get; set; }
        private Type[] typeList = null;

        #region 修改数据库结构，及生成Api使用，正常运行或测试请屏蔽

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            typeList = Assembly.GetExecutingAssembly().GetTypes();
            //modelBuilder.Entity<Permission>();
            //modelBuilder.Entity<Role>();
            //modelBuilder.Entity<BirdData>();

            //级联
            //modelBuilder.Entity<UserGroups>()
            //    .HasMany(p => p.userInfos)
            //    .WithOne(p => p.UserGroups);
            //.OnDelete(DeleteBehavior.Cascade);

            //多对多的关系搭建
            modelBuilder.Entity<RolePermission>()
            .HasKey(t => new { t.PermissionId, t.RoleID });
            //多对多的关系搭建
            modelBuilder.Entity<RolePermission>()
                .HasOne(pt => pt.Role)
                .WithMany(p => p.RolePermission)
                .HasForeignKey(pt => pt.RoleID);
            //多对多的关系搭建
            modelBuilder.Entity<RolePermission>()
                .HasOne(pt => pt.permission)
                .WithMany(t => t.RolePermission)
                .HasForeignKey(pt => pt.PermissionId);

            //反射给数据库赋上默认值
            if (typeList != null)
            {
                foreach (Type typeData in typeList)
                {
                    if (typeData.Name != "BaseClass" && typeof(BaseClass).IsAssignableFrom(typeData))
                    {
                        //mysql默认值
                        modelBuilder.Entity(typeData)
                            .Property("CreatedTime")
                            .HasDefaultValueSql("CURRENT_TIMESTAMP");

                        modelBuilder.Entity(typeData)
                            .Property("ModifiedTime")
                            .HasDefaultValueSql("CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP");

                        //sqlserver默认值
                        //modelBuilder.Entity(typeData)
                        //  .Property("CreatedTime")
                        //  .HasDefaultValueSql("getdate()");

                        //modelBuilder.Entity(typeData)
                        //    .Property("ModifiedTime")
                        //    .HasDefaultValueSql("getdate()");
                    }
                }
            }
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //配置Mysql连接字符串
            optionsBuilder.UseMySql("Server=172.25.2.13;Port=3306;Database=Test;User=root;Password=JHjiahong481;");
            //optionsBuilder.UseSqlServer("Server=172.25.2.11;Database=MES3_Test;User=sa;Password=JHjiahong481;");
        }
        #endregion
    }
}
