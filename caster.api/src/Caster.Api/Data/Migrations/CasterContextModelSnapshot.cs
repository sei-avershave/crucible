/*
Crucible
Copyright 2020 Carnegie Mellon University.
NO WARRANTY. THIS CARNEGIE MELLON UNIVERSITY AND SOFTWARE ENGINEERING INSTITUTE MATERIAL IS FURNISHED ON AN "AS-IS" BASIS. CARNEGIE MELLON UNIVERSITY MAKES NO WARRANTIES OF ANY KIND, EITHER EXPRESSED OR IMPLIED, AS TO ANY MATTER INCLUDING, BUT NOT LIMITED TO, WARRANTY OF FITNESS FOR PURPOSE OR MERCHANTABILITY, EXCLUSIVITY, OR RESULTS OBTAINED FROM USE OF THE MATERIAL. CARNEGIE MELLON UNIVERSITY DOES NOT MAKE ANY WARRANTY OF ANY KIND WITH RESPECT TO FREEDOM FROM PATENT, TRADEMARK, OR COPYRIGHT INFRINGEMENT.
Released under a MIT (SEI)-style license, please see license.txt or contact permission@sei.cmu.edu for full terms.
[DISTRIBUTION STATEMENT A] This material has been approved for public release and unlimited distribution.  Please see Copyright notice for non-US Government use and distribution.
Carnegie Mellon(R) and CERT(R) are registered in the U.S. Patent and Trademark Office by Carnegie Mellon University.
DM20-0181
*/

// <auto-generated />
using System;
using Caster.Api.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Caster.Api.Data.Migrations
{
    [DbContext(typeof(CasterContext))]
    partial class CasterContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:PostgresExtension:uuid-ossp", ",,")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Caster.Api.Domain.Models.Apply", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("uuid")
                        .HasDefaultValueSql("uuid_generate_v4()");

                    b.Property<string>("Output")
                        .HasColumnName("output")
                        .HasColumnType("text");

                    b.Property<Guid>("RunId")
                        .HasColumnName("run_id")
                        .HasColumnType("uuid");

                    b.Property<int>("Status")
                        .HasColumnName("status")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("RunId")
                        .IsUnique();

                    b.ToTable("applies");
                });

            modelBuilder.Entity("Caster.Api.Domain.Models.Directory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("uuid")
                        .HasDefaultValueSql("uuid_generate_v4()");

                    b.Property<Guid>("ExerciseId")
                        .HasColumnName("exercise_id")
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .HasColumnName("name")
                        .HasColumnType("text");

                    b.Property<Guid?>("ParentId")
                        .HasColumnName("parent_id")
                        .HasColumnType("uuid");

                    b.Property<string>("Path")
                        .HasColumnName("path")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("ExerciseId");

                    b.HasIndex("ParentId");

                    b.HasIndex("Path");

                    b.ToTable("directories");
                });

            modelBuilder.Entity("Caster.Api.Domain.Models.Exercise", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("uuid")
                        .HasDefaultValueSql("uuid_generate_v4()");

                    b.Property<string>("Name")
                        .HasColumnName("name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("exercises");
                });

            modelBuilder.Entity("Caster.Api.Domain.Models.File", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("uuid")
                        .HasDefaultValueSql("uuid_generate_v4()");

                    b.Property<bool>("AdministrativelyLocked")
                        .HasColumnName("administratively_locked")
                        .HasColumnType("boolean");

                    b.Property<string>("Content")
                        .HasColumnName("content")
                        .HasColumnType("text");

                    b.Property<DateTime?>("DateSaved")
                        .HasColumnName("date_saved")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid>("DirectoryId")
                        .HasColumnName("directory_id")
                        .HasColumnType("uuid");

                    b.Property<bool>("IsDeleted")
                        .HasColumnName("is_deleted")
                        .HasColumnType("boolean");

                    b.Property<Guid?>("LockedById")
                        .HasColumnName("locked_by_id")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("ModifiedById")
                        .HasColumnName("modified_by_id")
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .HasColumnName("name")
                        .HasColumnType("text");

                    b.Property<Guid?>("WorkspaceId")
                        .HasColumnName("workspace_id")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("DirectoryId");

                    b.HasIndex("LockedById");

                    b.HasIndex("ModifiedById");

                    b.HasIndex("WorkspaceId");

                    b.ToTable("files");
                });

            modelBuilder.Entity("Caster.Api.Domain.Models.FileVersion", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("uuid")
                        .HasDefaultValueSql("uuid_generate_v4()");

                    b.Property<string>("Content")
                        .HasColumnName("content")
                        .HasColumnType("text");

                    b.Property<DateTime?>("DateSaved")
                        .HasColumnName("date_saved")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("DateTagged")
                        .HasColumnName("date_tagged")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid>("FileId")
                        .HasColumnName("file_id")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("ModifiedById")
                        .HasColumnName("modified_by_id")
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .HasColumnName("name")
                        .HasColumnType("text");

                    b.Property<string>("Tag")
                        .HasColumnName("tag")
                        .HasColumnType("text");

                    b.Property<Guid?>("TaggedById")
                        .HasColumnName("tagged_by_id")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("FileId");

                    b.HasIndex("ModifiedById");

                    b.HasIndex("TaggedById");

                    b.ToTable("file_versions");
                });

            modelBuilder.Entity("Caster.Api.Domain.Models.Host", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("uuid")
                        .HasDefaultValueSql("uuid_generate_v4()");

                    b.Property<string>("Datastore")
                        .HasColumnName("datastore")
                        .HasColumnType("text");

                    b.Property<bool>("Development")
                        .HasColumnName("development")
                        .HasColumnType("boolean");

                    b.Property<bool>("Enabled")
                        .HasColumnName("enabled")
                        .HasColumnType("boolean");

                    b.Property<Guid?>("ExerciseId")
                        .HasColumnName("exercise_id")
                        .HasColumnType("uuid");

                    b.Property<int>("MaximumMachines")
                        .HasColumnName("maximum_machines")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .HasColumnName("name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("ExerciseId");

                    b.ToTable("hosts");
                });

            modelBuilder.Entity("Caster.Api.Domain.Models.HostMachine", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("uuid")
                        .HasDefaultValueSql("uuid_generate_v4()");

                    b.Property<Guid>("HostId")
                        .HasColumnName("host_id")
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .HasColumnName("name")
                        .HasColumnType("text");

                    b.Property<Guid>("WorkspaceId")
                        .HasColumnName("workspace_id")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("HostId");

                    b.HasIndex("WorkspaceId");

                    b.ToTable("host_machines");
                });

            modelBuilder.Entity("Caster.Api.Domain.Models.Module", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("uuid")
                        .HasDefaultValueSql("uuid_generate_v4()");

                    b.Property<DateTime?>("DateModified")
                        .HasColumnName("date_modified")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Description")
                        .HasColumnName("description")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnName("name")
                        .HasColumnType("text");

                    b.Property<string>("Path")
                        .HasColumnName("path")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("modules");
                });

            modelBuilder.Entity("Caster.Api.Domain.Models.ModuleVersion", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("uuid")
                        .HasDefaultValueSql("uuid_generate_v4()");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnName("date_created")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid>("ModuleId")
                        .HasColumnName("module_id")
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .HasColumnName("name")
                        .HasColumnType("text");

                    b.Property<string>("Outputs")
                        .HasColumnName("outputs")
                        .HasColumnType("text");

                    b.Property<string>("UrlLink")
                        .HasColumnName("url_link")
                        .HasColumnType("text");

                    b.Property<string>("Variables")
                        .HasColumnName("variables")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("ModuleId");

                    b.ToTable("module_versions");
                });

            modelBuilder.Entity("Caster.Api.Domain.Models.Permission", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("uuid")
                        .HasDefaultValueSql("uuid_generate_v4()");

                    b.Property<string>("Description")
                        .HasColumnName("description")
                        .HasColumnType("text");

                    b.Property<string>("Key")
                        .HasColumnName("key")
                        .HasColumnType("text");

                    b.Property<bool>("ReadOnly")
                        .HasColumnName("read_only")
                        .HasColumnType("boolean");

                    b.Property<string>("Value")
                        .HasColumnName("value")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("Key", "Value")
                        .IsUnique();

                    b.ToTable("permissions");
                });

            modelBuilder.Entity("Caster.Api.Domain.Models.Plan", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("uuid")
                        .HasDefaultValueSql("uuid_generate_v4()");

                    b.Property<string>("Output")
                        .HasColumnName("output")
                        .HasColumnType("text");

                    b.Property<Guid>("RunId")
                        .HasColumnName("run_id")
                        .HasColumnType("uuid");

                    b.Property<int>("Status")
                        .HasColumnName("status")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("RunId")
                        .IsUnique();

                    b.ToTable("plans");
                });

            modelBuilder.Entity("Caster.Api.Domain.Models.RemovedResource", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnName("id")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("removed_resources");
                });

            modelBuilder.Entity("Caster.Api.Domain.Models.Run", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("uuid")
                        .HasDefaultValueSql("uuid_generate_v4()");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnName("created_at")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("IsDestroy")
                        .HasColumnName("is_destroy")
                        .HasColumnType("boolean");

                    b.Property<int>("Status")
                        .HasColumnName("status")
                        .HasColumnType("integer");

                    b.Property<string>("Targets")
                        .HasColumnName("targets")
                        .HasColumnType("text");

                    b.Property<Guid>("WorkspaceId")
                        .HasColumnName("workspace_id")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("CreatedAt");

                    b.HasIndex("WorkspaceId");

                    b.ToTable("runs");
                });

            modelBuilder.Entity("Caster.Api.Domain.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("uuid")
                        .HasDefaultValueSql("uuid_generate_v4()");

                    b.Property<string>("Name")
                        .HasColumnName("name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("users");
                });

            modelBuilder.Entity("Caster.Api.Domain.Models.UserPermission", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("uuid")
                        .HasDefaultValueSql("uuid_generate_v4()");

                    b.Property<Guid>("PermissionId")
                        .HasColumnName("permission_id")
                        .HasColumnType("uuid");

                    b.Property<Guid>("UserId")
                        .HasColumnName("user_id")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("PermissionId");

                    b.HasIndex("UserId", "PermissionId")
                        .IsUnique();

                    b.ToTable("user_permissions");
                });

            modelBuilder.Entity("Caster.Api.Domain.Models.Workspace", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("uuid")
                        .HasDefaultValueSql("uuid_generate_v4()");

                    b.Property<Guid>("DirectoryId")
                        .HasColumnName("directory_id")
                        .HasColumnType("uuid");

                    b.Property<bool>("DynamicHost")
                        .HasColumnName("dynamic_host")
                        .HasColumnType("boolean");

                    b.Property<Guid?>("HostId")
                        .HasColumnName("host_id")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("LastSynced")
                        .HasColumnName("last_synced")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Name")
                        .HasColumnName("name")
                        .HasColumnType("text");

                    b.Property<string>("State")
                        .HasColumnName("state")
                        .HasColumnType("text");

                    b.Property<string>("StateBackup")
                        .HasColumnName("state_backup")
                        .HasColumnType("text");

                    b.Property<string>("SyncErrors")
                        .HasColumnName("sync_errors")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("DirectoryId");

                    b.HasIndex("HostId");

                    b.ToTable("workspaces");
                });

            modelBuilder.Entity("Caster.Api.Domain.Models.Apply", b =>
                {
                    b.HasOne("Caster.Api.Domain.Models.Run", "Run")
                        .WithOne("Apply")
                        .HasForeignKey("Caster.Api.Domain.Models.Apply", "RunId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Caster.Api.Domain.Models.Directory", b =>
                {
                    b.HasOne("Caster.Api.Domain.Models.Exercise", "Exercise")
                        .WithMany("Directories")
                        .HasForeignKey("ExerciseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Caster.Api.Domain.Models.Directory", "Parent")
                        .WithMany("Children")
                        .HasForeignKey("ParentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Caster.Api.Domain.Models.File", b =>
                {
                    b.HasOne("Caster.Api.Domain.Models.Directory", "Directory")
                        .WithMany("Files")
                        .HasForeignKey("DirectoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Caster.Api.Domain.Models.User", "LockedBy")
                        .WithMany()
                        .HasForeignKey("LockedById");

                    b.HasOne("Caster.Api.Domain.Models.User", "ModifiedBy")
                        .WithMany()
                        .HasForeignKey("ModifiedById");

                    b.HasOne("Caster.Api.Domain.Models.Workspace", "Workspace")
                        .WithMany("Files")
                        .HasForeignKey("WorkspaceId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Caster.Api.Domain.Models.FileVersion", b =>
                {
                    b.HasOne("Caster.Api.Domain.Models.File", "File")
                        .WithMany("FileVersions")
                        .HasForeignKey("FileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Caster.Api.Domain.Models.User", "ModifiedBy")
                        .WithMany()
                        .HasForeignKey("ModifiedById");

                    b.HasOne("Caster.Api.Domain.Models.User", "TaggedBy")
                        .WithMany()
                        .HasForeignKey("TaggedById");
                });

            modelBuilder.Entity("Caster.Api.Domain.Models.Host", b =>
                {
                    b.HasOne("Caster.Api.Domain.Models.Exercise", "Exercise")
                        .WithMany()
                        .HasForeignKey("ExerciseId");
                });

            modelBuilder.Entity("Caster.Api.Domain.Models.HostMachine", b =>
                {
                    b.HasOne("Caster.Api.Domain.Models.Host", "Host")
                        .WithMany("Machines")
                        .HasForeignKey("HostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Caster.Api.Domain.Models.Workspace", "Workspace")
                        .WithMany()
                        .HasForeignKey("WorkspaceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Caster.Api.Domain.Models.ModuleVersion", b =>
                {
                    b.HasOne("Caster.Api.Domain.Models.Module", "Module")
                        .WithMany("Versions")
                        .HasForeignKey("ModuleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Caster.Api.Domain.Models.Plan", b =>
                {
                    b.HasOne("Caster.Api.Domain.Models.Run", "Run")
                        .WithOne("Plan")
                        .HasForeignKey("Caster.Api.Domain.Models.Plan", "RunId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Caster.Api.Domain.Models.Run", b =>
                {
                    b.HasOne("Caster.Api.Domain.Models.Workspace", "Workspace")
                        .WithMany("Runs")
                        .HasForeignKey("WorkspaceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Caster.Api.Domain.Models.UserPermission", b =>
                {
                    b.HasOne("Caster.Api.Domain.Models.Permission", "Permission")
                        .WithMany("UserPermissions")
                        .HasForeignKey("PermissionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Caster.Api.Domain.Models.User", "User")
                        .WithMany("UserPermissions")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Caster.Api.Domain.Models.Workspace", b =>
                {
                    b.HasOne("Caster.Api.Domain.Models.Directory", "Directory")
                        .WithMany("Workspaces")
                        .HasForeignKey("DirectoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Caster.Api.Domain.Models.Host", "Host")
                        .WithMany()
                        .HasForeignKey("HostId");
                });
#pragma warning restore 612, 618
        }
    }
}
