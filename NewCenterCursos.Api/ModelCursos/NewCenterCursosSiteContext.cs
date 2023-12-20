using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace NewCenterCursos.Api.ModelCursos
{
    public partial class NewCenterCursosSiteContext : DbContext
    {
        public NewCenterCursosSiteContext()
        {
        }

        public NewCenterCursosSiteContext(DbContextOptions<NewCenterCursosSiteContext> options)
            : base(options)
        {
        }

        public virtual DbSet<WpActionschedulerAction> WpActionschedulerActions { get; set; } = null!;
        public virtual DbSet<WpActionschedulerClaim> WpActionschedulerClaims { get; set; } = null!;
        public virtual DbSet<WpActionschedulerGroup> WpActionschedulerGroups { get; set; } = null!;
        public virtual DbSet<WpActionschedulerLog> WpActionschedulerLogs { get; set; } = null!;
        public virtual DbSet<WpComment> WpComments { get; set; } = null!;
        public virtual DbSet<WpCommentmetum> WpCommentmeta { get; set; } = null!;
        public virtual DbSet<WpDuplicatorPackage> WpDuplicatorPackages { get; set; } = null!;
        public virtual DbSet<WpEEvent> WpEEvents { get; set; } = null!;
        public virtual DbSet<WpESubmission> WpESubmissions { get; set; } = null!;
        public virtual DbSet<WpESubmissionsActionsLog> WpESubmissionsActionsLogs { get; set; } = null!;
        public virtual DbSet<WpESubmissionsValue> WpESubmissionsValues { get; set; } = null!;
        public virtual DbSet<WpEasyCustomJsAndCss> WpEasyCustomJsAndCsses { get; set; } = null!;
        public virtual DbSet<WpEasyCustomJsAndCssFilter> WpEasyCustomJsAndCssFilters { get; set; } = null!;
        public virtual DbSet<WpLayerslider> WpLayersliders { get; set; } = null!;
        public virtual DbSet<WpLayersliderRevision> WpLayersliderRevisions { get; set; } = null!;
        public virtual DbSet<WpLink> WpLinks { get; set; } = null!;
        public virtual DbSet<WpLitespeedUrl> WpLitespeedUrls { get; set; } = null!;
        public virtual DbSet<WpLitespeedUrlFile> WpLitespeedUrlFiles { get; set; } = null!;
        public virtual DbSet<WpNf3Action> WpNf3Actions { get; set; } = null!;
        public virtual DbSet<WpNf3ActionMetum> WpNf3ActionMeta { get; set; } = null!;
        public virtual DbSet<WpNf3Chunk> WpNf3Chunks { get; set; } = null!;
        public virtual DbSet<WpNf3Field> WpNf3Fields { get; set; } = null!;
        public virtual DbSet<WpNf3FieldMetum> WpNf3FieldMeta { get; set; } = null!;
        public virtual DbSet<WpNf3Form> WpNf3Forms { get; set; } = null!;
        public virtual DbSet<WpNf3FormMetum> WpNf3FormMeta { get; set; } = null!;
        public virtual DbSet<WpNf3Object> WpNf3Objects { get; set; } = null!;
        public virtual DbSet<WpNf3ObjectMetum> WpNf3ObjectMeta { get; set; } = null!;
        public virtual DbSet<WpNf3Relationship> WpNf3Relationships { get; set; } = null!;
        public virtual DbSet<WpNf3Upgrade> WpNf3Upgrades { get; set; } = null!;
        public virtual DbSet<WpOption> WpOptions { get; set; } = null!;
        public virtual DbSet<WpPost> WpPosts { get; set; } = null!;
        public virtual DbSet<WpPostmetum> WpPostmeta { get; set; } = null!;
        public virtual DbSet<WpTerm> WpTerms { get; set; } = null!;
        public virtual DbSet<WpTermRelationship> WpTermRelationships { get; set; } = null!;
        public virtual DbSet<WpTermTaxonomy> WpTermTaxonomies { get; set; } = null!;
        public virtual DbSet<WpTermmetum> WpTermmeta { get; set; } = null!;
        public virtual DbSet<WpUser> WpUsers { get; set; } = null!;
        public virtual DbSet<WpUsermetum> WpUsermeta { get; set; } = null!;
        public virtual DbSet<WpWpformsPayment> WpWpformsPayments { get; set; } = null!;
        public virtual DbSet<WpWpformsPaymentMetum> WpWpformsPaymentMeta { get; set; } = null!;
        public virtual DbSet<WpWpformsTasksMetum> WpWpformsTasksMeta { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySql("server=localhost;database=newcentercursos;uid=root;pwd=kE@laqJLl#1DM", Microsoft.EntityFrameworkCore.ServerVersion.Parse("10.6.15-mariadb"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("utf8mb4_general_ci")
                .HasCharSet("utf8mb4");

            modelBuilder.Entity<WpActionschedulerAction>(entity =>
            {
                entity.HasKey(e => e.ActionId)
                    .HasName("PRIMARY");

                entity.ToTable("wp_actionscheduler_actions");

                entity.UseCollation("utf8mb4_unicode_520_ci");

                entity.HasIndex(e => e.Args, "args");

                entity.HasIndex(e => new { e.ClaimId, e.Status, e.ScheduledDateGmt }, "claim_id_status_scheduled_date_gmt");

                entity.HasIndex(e => e.GroupId, "group_id");

                entity.HasIndex(e => e.Hook, "hook");

                entity.HasIndex(e => e.LastAttemptGmt, "last_attempt_gmt");

                entity.HasIndex(e => e.ScheduledDateGmt, "scheduled_date_gmt");

                entity.HasIndex(e => e.Status, "status");

                entity.Property(e => e.ActionId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("action_id");

                entity.Property(e => e.Args)
                    .HasMaxLength(191)
                    .HasColumnName("args");

                entity.Property(e => e.Attempts)
                    .HasColumnType("int(11)")
                    .HasColumnName("attempts");

                entity.Property(e => e.ClaimId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("claim_id");

                entity.Property(e => e.ExtendedArgs)
                    .HasMaxLength(8000)
                    .HasColumnName("extended_args");

                entity.Property(e => e.GroupId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("group_id");

                entity.Property(e => e.Hook)
                    .HasMaxLength(191)
                    .HasColumnName("hook");

                entity.Property(e => e.LastAttemptGmt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_attempt_gmt")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.LastAttemptLocal)
                    .HasColumnType("datetime")
                    .HasColumnName("last_attempt_local")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.Schedule).HasColumnName("schedule");

                entity.Property(e => e.ScheduledDateGmt)
                    .HasColumnType("datetime")
                    .HasColumnName("scheduled_date_gmt")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.ScheduledDateLocal)
                    .HasColumnType("datetime")
                    .HasColumnName("scheduled_date_local")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.Status)
                    .HasMaxLength(20)
                    .HasColumnName("status");
            });

            modelBuilder.Entity<WpActionschedulerClaim>(entity =>
            {
                entity.HasKey(e => e.ClaimId)
                    .HasName("PRIMARY");

                entity.ToTable("wp_actionscheduler_claims");

                entity.UseCollation("utf8mb4_unicode_520_ci");

                entity.HasIndex(e => e.DateCreatedGmt, "date_created_gmt");

                entity.Property(e => e.ClaimId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("claim_id");

                entity.Property(e => e.DateCreatedGmt)
                    .HasColumnType("datetime")
                    .HasColumnName("date_created_gmt")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");
            });

            modelBuilder.Entity<WpActionschedulerGroup>(entity =>
            {
                entity.HasKey(e => e.GroupId)
                    .HasName("PRIMARY");

                entity.ToTable("wp_actionscheduler_groups");

                entity.UseCollation("utf8mb4_unicode_520_ci");

                entity.HasIndex(e => e.Slug, "slug")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 191 });

                entity.Property(e => e.GroupId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("group_id");

                entity.Property(e => e.Slug).HasColumnName("slug");
            });

            modelBuilder.Entity<WpActionschedulerLog>(entity =>
            {
                entity.HasKey(e => e.LogId)
                    .HasName("PRIMARY");

                entity.ToTable("wp_actionscheduler_logs");

                entity.UseCollation("utf8mb4_unicode_520_ci");

                entity.HasIndex(e => e.ActionId, "action_id");

                entity.HasIndex(e => e.LogDateGmt, "log_date_gmt");

                entity.Property(e => e.LogId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("log_id");

                entity.Property(e => e.ActionId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("action_id");

                entity.Property(e => e.LogDateGmt)
                    .HasColumnType("datetime")
                    .HasColumnName("log_date_gmt")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.LogDateLocal)
                    .HasColumnType("datetime")
                    .HasColumnName("log_date_local")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.Message)
                    .HasColumnType("text")
                    .HasColumnName("message");
            });

            modelBuilder.Entity<WpComment>(entity =>
            {
                entity.HasKey(e => e.CommentId)
                    .HasName("PRIMARY");

                entity.ToTable("wp_comments");

                entity.UseCollation("utf8mb4_unicode_520_ci");

                entity.HasIndex(e => new { e.CommentApproved, e.CommentDateGmt }, "comment_approved_date_gmt");

                entity.HasIndex(e => e.CommentAuthorEmail, "comment_author_email")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 10 });

                entity.HasIndex(e => e.CommentDateGmt, "comment_date_gmt");

                entity.HasIndex(e => e.CommentParent, "comment_parent");

                entity.HasIndex(e => e.CommentPostId, "comment_post_ID");

                entity.Property(e => e.CommentId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("comment_ID");

                entity.Property(e => e.CommentAgent)
                    .HasMaxLength(255)
                    .HasColumnName("comment_agent")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CommentApproved)
                    .HasMaxLength(20)
                    .HasColumnName("comment_approved")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.CommentAuthor)
                    .HasColumnType("tinytext")
                    .HasColumnName("comment_author");

                entity.Property(e => e.CommentAuthorEmail)
                    .HasMaxLength(100)
                    .HasColumnName("comment_author_email")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CommentAuthorIp)
                    .HasMaxLength(100)
                    .HasColumnName("comment_author_IP")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CommentAuthorUrl)
                    .HasMaxLength(200)
                    .HasColumnName("comment_author_url")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CommentContent)
                    .HasColumnType("text")
                    .HasColumnName("comment_content");

                entity.Property(e => e.CommentDate)
                    .HasColumnType("datetime")
                    .HasColumnName("comment_date")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.CommentDateGmt)
                    .HasColumnType("datetime")
                    .HasColumnName("comment_date_gmt")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.CommentKarma)
                    .HasColumnType("int(11)")
                    .HasColumnName("comment_karma");

                entity.Property(e => e.CommentParent)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("comment_parent");

                entity.Property(e => e.CommentPostId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("comment_post_ID");

                entity.Property(e => e.CommentType)
                    .HasMaxLength(20)
                    .HasColumnName("comment_type")
                    .HasDefaultValueSql("'comment'");

                entity.Property(e => e.UserId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("user_id");
            });

            modelBuilder.Entity<WpCommentmetum>(entity =>
            {
                entity.HasKey(e => e.MetaId)
                    .HasName("PRIMARY");

                entity.ToTable("wp_commentmeta");

                entity.UseCollation("utf8mb4_unicode_520_ci");

                entity.HasIndex(e => e.CommentId, "comment_id");

                entity.HasIndex(e => e.MetaKey, "meta_key")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 191 });

                entity.Property(e => e.MetaId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("meta_id");

                entity.Property(e => e.CommentId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("comment_id");

                entity.Property(e => e.MetaKey).HasColumnName("meta_key");

                entity.Property(e => e.MetaValue).HasColumnName("meta_value");
            });

            modelBuilder.Entity<WpDuplicatorPackage>(entity =>
            {
                entity.ToTable("wp_duplicator_packages");

                entity.UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.Hash, "hash");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.Hash)
                    .HasMaxLength(50)
                    .HasColumnName("hash");

                entity.Property(e => e.Name)
                    .HasMaxLength(250)
                    .HasColumnName("name");

                entity.Property(e => e.Owner)
                    .HasMaxLength(60)
                    .HasColumnName("owner");

                entity.Property(e => e.Package).HasColumnName("package");

                entity.Property(e => e.Status)
                    .HasColumnType("int(11)")
                    .HasColumnName("status");
            });

            modelBuilder.Entity<WpEEvent>(entity =>
            {
                entity.ToTable("wp_e_events");

                entity.UseCollation("utf8mb4_unicode_520_ci");

                entity.HasIndex(e => e.CreatedAt, "created_at_index");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at");

                entity.Property(e => e.EventData)
                    .HasColumnType("text")
                    .HasColumnName("event_data");
            });

            modelBuilder.Entity<WpESubmission>(entity =>
            {
                entity.ToTable("wp_e_submissions");

                entity.UseCollation("utf8mb4_unicode_520_ci");

                entity.HasIndex(e => e.CampaignId, "campaign_id_index");

                entity.HasIndex(e => e.CreatedAtGmt, "created_at_gmt_index");

                entity.HasIndex(e => e.CreatedAt, "created_at_index");

                entity.HasIndex(e => e.ElementId, "element_id_index");

                entity.HasIndex(e => e.HashId, "hash_id_index")
                    .IsUnique();

                entity.HasIndex(e => e.IsRead, "is_read_index");

                entity.HasIndex(e => e.MainMetaId, "main_meta_id_index");

                entity.HasIndex(e => e.PostId, "post_id_index");

                entity.HasIndex(e => e.Referer, "referer_index")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 191 });

                entity.HasIndex(e => e.RefererTitle, "referer_title_index")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 191 });

                entity.HasIndex(e => e.Status, "status_index");

                entity.HasIndex(e => e.Type, "type_index");

                entity.HasIndex(e => e.UpdatedAtGmt, "updated_at_gmt_index");

                entity.HasIndex(e => e.UpdatedAt, "updated_at_index");

                entity.HasIndex(e => e.UserId, "user_id_index");

                entity.HasIndex(e => e.UserIp, "user_ip_index");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.ActionsCount)
                    .HasColumnType("int(11)")
                    .HasColumnName("actions_count")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ActionsSucceededCount)
                    .HasColumnType("int(11)")
                    .HasColumnName("actions_succeeded_count")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.CampaignId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("campaign_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedAtGmt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at_gmt");

                entity.Property(e => e.ElementId)
                    .HasMaxLength(20)
                    .HasColumnName("element_id");

                entity.Property(e => e.FormName)
                    .HasMaxLength(60)
                    .HasColumnName("form_name");

                entity.Property(e => e.HashId)
                    .HasMaxLength(60)
                    .HasColumnName("hash_id");

                entity.Property(e => e.IsRead).HasColumnName("is_read");

                entity.Property(e => e.MainMetaId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("main_meta_id")
                    .HasComment("Id of main field. to represent the main meta field");

                entity.Property(e => e.Meta)
                    .HasColumnType("text")
                    .HasColumnName("meta");

                entity.Property(e => e.PostId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("post_id");

                entity.Property(e => e.Referer)
                    .HasMaxLength(500)
                    .HasColumnName("referer");

                entity.Property(e => e.RefererTitle)
                    .HasMaxLength(300)
                    .HasColumnName("referer_title");

                entity.Property(e => e.Status)
                    .HasMaxLength(20)
                    .HasColumnName("status");

                entity.Property(e => e.Type)
                    .HasMaxLength(60)
                    .HasColumnName("type");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at");

                entity.Property(e => e.UpdatedAtGmt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at_gmt");

                entity.Property(e => e.UserAgent)
                    .HasColumnType("text")
                    .HasColumnName("user_agent");

                entity.Property(e => e.UserId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("user_id");

                entity.Property(e => e.UserIp)
                    .HasMaxLength(46)
                    .HasColumnName("user_ip");
            });

            modelBuilder.Entity<WpESubmissionsActionsLog>(entity =>
            {
                entity.ToTable("wp_e_submissions_actions_log");

                entity.UseCollation("utf8mb4_unicode_520_ci");

                entity.HasIndex(e => e.ActionName, "action_name_index");

                entity.HasIndex(e => e.CreatedAtGmt, "created_at_gmt_index");

                entity.HasIndex(e => e.CreatedAt, "created_at_index");

                entity.HasIndex(e => e.Status, "status_index");

                entity.HasIndex(e => e.SubmissionId, "submission_id_index");

                entity.HasIndex(e => e.UpdatedAtGmt, "updated_at_gmt_index");

                entity.HasIndex(e => e.UpdatedAt, "updated_at_index");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.ActionLabel)
                    .HasMaxLength(60)
                    .HasColumnName("action_label");

                entity.Property(e => e.ActionName)
                    .HasMaxLength(60)
                    .HasColumnName("action_name");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedAtGmt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at_gmt");

                entity.Property(e => e.Log)
                    .HasColumnType("text")
                    .HasColumnName("log");

                entity.Property(e => e.Status)
                    .HasMaxLength(20)
                    .HasColumnName("status");

                entity.Property(e => e.SubmissionId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("submission_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at");

                entity.Property(e => e.UpdatedAtGmt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at_gmt");
            });

            modelBuilder.Entity<WpESubmissionsValue>(entity =>
            {
                entity.ToTable("wp_e_submissions_values");

                entity.UseCollation("utf8mb4_unicode_520_ci");

                entity.HasIndex(e => e.Key, "key_index");

                entity.HasIndex(e => e.SubmissionId, "submission_id_index");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Key)
                    .HasMaxLength(60)
                    .HasColumnName("key");

                entity.Property(e => e.SubmissionId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("submission_id");

                entity.Property(e => e.Value).HasColumnName("value");
            });

            modelBuilder.Entity<WpEasyCustomJsAndCss>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("wp_easy_custom_js_and_css");

                entity.UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.Id, "id")
                    .IsUnique();

                entity.Property(e => e.Active)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("active")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Author)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("author");

                entity.Property(e => e.Data).HasColumnName("data");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("date")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasColumnName("modified")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.Options)
                    .HasColumnType("text")
                    .HasColumnName("options");

                entity.Property(e => e.Priority)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("priority");

                entity.Property(e => e.Title)
                    .HasColumnType("text")
                    .HasColumnName("title");

                entity.Property(e => e.Type)
                    .HasMaxLength(8)
                    .HasColumnName("type");
            });

            modelBuilder.Entity<WpEasyCustomJsAndCssFilter>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("wp_easy_custom_js_and_css_filters");

                entity.UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.Id, "id")
                    .IsUnique();

                entity.Property(e => e.Author)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("author");

                entity.Property(e => e.Data).HasColumnName("data");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("date")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasColumnName("modified")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.Title)
                    .HasColumnType("text")
                    .HasColumnName("title");
            });

            modelBuilder.Entity<WpLayerslider>(entity =>
            {
                entity.ToTable("wp_layerslider");

                entity.UseCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10)")
                    .HasColumnName("id");

                entity.Property(e => e.Author)
                    .HasColumnType("int(10)")
                    .HasColumnName("author");

                entity.Property(e => e.Data)
                    .HasColumnType("mediumtext")
                    .HasColumnName("data");

                entity.Property(e => e.DateC)
                    .HasColumnType("int(10)")
                    .HasColumnName("date_c");

                entity.Property(e => e.DateM)
                    .HasColumnType("int(10)")
                    .HasColumnName("date_m");

                entity.Property(e => e.FlagDeleted).HasColumnName("flag_deleted");

                entity.Property(e => e.FlagGroup).HasColumnName("flag_group");

                entity.Property(e => e.FlagHidden).HasColumnName("flag_hidden");

                entity.Property(e => e.FlagPopup).HasColumnName("flag_popup");

                entity.Property(e => e.GroupId)
                    .HasColumnType("int(10)")
                    .HasColumnName("group_id");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .HasColumnName("name")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ScheduleEnd)
                    .HasColumnType("int(10)")
                    .HasColumnName("schedule_end");

                entity.Property(e => e.ScheduleStart)
                    .HasColumnType("int(10)")
                    .HasColumnName("schedule_start");

                entity.Property(e => e.Slug)
                    .HasMaxLength(100)
                    .HasColumnName("slug")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<WpLayersliderRevision>(entity =>
            {
                entity.ToTable("wp_layerslider_revisions");

                entity.UseCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10)")
                    .HasColumnName("id");

                entity.Property(e => e.Author)
                    .HasColumnType("int(10)")
                    .HasColumnName("author");

                entity.Property(e => e.Data)
                    .HasColumnType("mediumtext")
                    .HasColumnName("data");

                entity.Property(e => e.DateC)
                    .HasColumnType("int(10)")
                    .HasColumnName("date_c");

                entity.Property(e => e.SliderId)
                    .HasColumnType("int(10)")
                    .HasColumnName("slider_id");
            });

            modelBuilder.Entity<WpLink>(entity =>
            {
                entity.HasKey(e => e.LinkId)
                    .HasName("PRIMARY");

                entity.ToTable("wp_links");

                entity.UseCollation("utf8mb4_unicode_520_ci");

                entity.HasIndex(e => e.LinkVisible, "link_visible");

                entity.Property(e => e.LinkId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("link_id");

                entity.Property(e => e.LinkDescription)
                    .HasMaxLength(255)
                    .HasColumnName("link_description")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.LinkImage)
                    .HasMaxLength(255)
                    .HasColumnName("link_image")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.LinkName)
                    .HasMaxLength(255)
                    .HasColumnName("link_name")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.LinkNotes)
                    .HasColumnType("mediumtext")
                    .HasColumnName("link_notes");

                entity.Property(e => e.LinkOwner)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("link_owner")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.LinkRating)
                    .HasColumnType("int(11)")
                    .HasColumnName("link_rating");

                entity.Property(e => e.LinkRel)
                    .HasMaxLength(255)
                    .HasColumnName("link_rel")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.LinkRss)
                    .HasMaxLength(255)
                    .HasColumnName("link_rss")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.LinkTarget)
                    .HasMaxLength(25)
                    .HasColumnName("link_target")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.LinkUpdated)
                    .HasColumnType("datetime")
                    .HasColumnName("link_updated")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.LinkUrl)
                    .HasMaxLength(255)
                    .HasColumnName("link_url")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.LinkVisible)
                    .HasMaxLength(20)
                    .HasColumnName("link_visible")
                    .HasDefaultValueSql("'Y'");
            });

            modelBuilder.Entity<WpLitespeedUrl>(entity =>
            {
                entity.ToTable("wp_litespeed_url");

                entity.UseCollation("utf8mb4_unicode_520_ci");

                entity.HasIndex(e => e.CacheTags, "cache_tags")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 191 });

                entity.HasIndex(e => e.Url, "url")
                    .IsUnique()
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 191 });

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");

                entity.Property(e => e.CacheTags)
                    .HasMaxLength(1000)
                    .HasColumnName("cache_tags")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Url)
                    .HasMaxLength(500)
                    .HasColumnName("url");
            });

            modelBuilder.Entity<WpLitespeedUrlFile>(entity =>
            {
                entity.ToTable("wp_litespeed_url_file");

                entity.UseCollation("utf8mb4_unicode_520_ci");

                entity.HasIndex(e => e.Filename, "filename");

                entity.HasIndex(e => new { e.Filename, e.Expired }, "filename_2");

                entity.HasIndex(e => e.Type, "type");

                entity.HasIndex(e => new { e.UrlId, e.Expired }, "url_id");

                entity.HasIndex(e => new { e.UrlId, e.Vary, e.Type }, "url_id_2");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");

                entity.Property(e => e.Expired)
                    .HasColumnType("int(11)")
                    .HasColumnName("expired");

                entity.Property(e => e.Filename)
                    .HasMaxLength(32)
                    .HasColumnName("filename")
                    .HasDefaultValueSql("''")
                    .HasComment("md5 of file content")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Mobile)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("mobile")
                    .HasComment("mobile=1");

                entity.Property(e => e.Type)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("type")
                    .HasComment("css=1,js=2,ccss=3,ucss=4");

                entity.Property(e => e.UrlId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("url_id");

                entity.Property(e => e.Vary)
                    .HasMaxLength(32)
                    .HasColumnName("vary")
                    .HasDefaultValueSql("''")
                    .HasComment("md5 of final vary")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Webp)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("webp")
                    .HasComment("webp=1");
            });

            modelBuilder.Entity<WpNf3Action>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("wp_nf3_actions");

                entity.HasIndex(e => e.Id, "id")
                    .IsUnique();

                entity.Property(e => e.Active)
                    .HasColumnName("active")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("current_timestamp()");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Key).HasColumnName("key");

                entity.Property(e => e.Label).HasColumnName("label");

                entity.Property(e => e.ParentId)
                    .HasColumnType("int(11)")
                    .HasColumnName("parent_id");

                entity.Property(e => e.Title).HasColumnName("title");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<WpNf3ActionMetum>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("wp_nf3_action_meta");

                entity.HasIndex(e => e.Id, "id")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Key).HasColumnName("key");

                entity.Property(e => e.MetaKey).HasColumnName("meta_key");

                entity.Property(e => e.MetaValue).HasColumnName("meta_value");

                entity.Property(e => e.ParentId)
                    .HasColumnType("int(11)")
                    .HasColumnName("parent_id");

                entity.Property(e => e.Value).HasColumnName("value");
            });

            modelBuilder.Entity<WpNf3Chunk>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("wp_nf3_chunks");

                entity.HasIndex(e => e.Id, "id")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .HasColumnName("name");

                entity.Property(e => e.Value).HasColumnName("value");
            });

            modelBuilder.Entity<WpNf3Field>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("wp_nf3_fields");

                entity.HasIndex(e => e.Id, "id")
                    .IsUnique();

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("current_timestamp()");

                entity.Property(e => e.DefaultValue).HasColumnName("default_value");

                entity.Property(e => e.FieldKey).HasColumnName("field_key");

                entity.Property(e => e.FieldLabel).HasColumnName("field_label");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Key).HasColumnName("key");

                entity.Property(e => e.Label).HasColumnName("label");

                entity.Property(e => e.LabelPos)
                    .HasMaxLength(15)
                    .HasColumnName("label_pos");

                entity.Property(e => e.Order)
                    .HasColumnType("int(11)")
                    .HasColumnName("order");

                entity.Property(e => e.ParentId)
                    .HasColumnType("int(11)")
                    .HasColumnName("parent_id");

                entity.Property(e => e.PersonallyIdentifiable)
                    .HasColumnType("bit(1)")
                    .HasColumnName("personally_identifiable");

                entity.Property(e => e.Required)
                    .HasColumnType("bit(1)")
                    .HasColumnName("required");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<WpNf3FieldMetum>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("wp_nf3_field_meta");

                entity.HasIndex(e => e.Id, "id")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Key).HasColumnName("key");

                entity.Property(e => e.MetaKey).HasColumnName("meta_key");

                entity.Property(e => e.MetaValue).HasColumnName("meta_value");

                entity.Property(e => e.ParentId)
                    .HasColumnType("int(11)")
                    .HasColumnName("parent_id");

                entity.Property(e => e.Value).HasColumnName("value");
            });

            modelBuilder.Entity<WpNf3Form>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("wp_nf3_forms");

                entity.HasIndex(e => e.Id, "id")
                    .IsUnique();

                entity.Property(e => e.ClearComplete)
                    .HasColumnType("bit(1)")
                    .HasColumnName("clear_complete");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("current_timestamp()");

                entity.Property(e => e.DefaultLabelPos)
                    .HasMaxLength(15)
                    .HasColumnName("default_label_pos");

                entity.Property(e => e.FormTitle).HasColumnName("form_title");

                entity.Property(e => e.HideComplete)
                    .HasColumnType("bit(1)")
                    .HasColumnName("hide_complete");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Key).HasColumnName("key");

                entity.Property(e => e.LoggedIn)
                    .HasColumnType("bit(1)")
                    .HasColumnName("logged_in");

                entity.Property(e => e.SeqNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("seq_num");

                entity.Property(e => e.ShowTitle)
                    .HasColumnType("bit(1)")
                    .HasColumnName("show_title");

                entity.Property(e => e.Subs)
                    .HasColumnType("int(11)")
                    .HasColumnName("subs");

                entity.Property(e => e.Title).HasColumnName("title");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at");

                entity.Property(e => e.Views)
                    .HasColumnType("int(11)")
                    .HasColumnName("views");
            });

            modelBuilder.Entity<WpNf3FormMetum>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("wp_nf3_form_meta");

                entity.HasIndex(e => e.Id, "id")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Key).HasColumnName("key");

                entity.Property(e => e.MetaKey).HasColumnName("meta_key");

                entity.Property(e => e.MetaValue).HasColumnName("meta_value");

                entity.Property(e => e.ParentId)
                    .HasColumnType("int(11)")
                    .HasColumnName("parent_id");

                entity.Property(e => e.Value).HasColumnName("value");
            });

            modelBuilder.Entity<WpNf3Object>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("wp_nf3_objects");

                entity.HasIndex(e => e.Id, "id")
                    .IsUnique();

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("current_timestamp()");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.ObjectTitle).HasColumnName("object_title");

                entity.Property(e => e.Title).HasColumnName("title");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<WpNf3ObjectMetum>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("wp_nf3_object_meta");

                entity.HasIndex(e => e.Id, "id")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Key).HasColumnName("key");

                entity.Property(e => e.MetaKey).HasColumnName("meta_key");

                entity.Property(e => e.MetaValue).HasColumnName("meta_value");

                entity.Property(e => e.ParentId)
                    .HasColumnType("int(11)")
                    .HasColumnName("parent_id");

                entity.Property(e => e.Value).HasColumnName("value");
            });

            modelBuilder.Entity<WpNf3Relationship>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("wp_nf3_relationships");

                entity.HasIndex(e => e.Id, "id")
                    .IsUnique();

                entity.Property(e => e.ChildId)
                    .HasColumnType("int(11)")
                    .HasColumnName("child_id");

                entity.Property(e => e.ChildType).HasColumnName("child_type");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("current_timestamp()");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.ParentId)
                    .HasColumnType("int(11)")
                    .HasColumnName("parent_id");

                entity.Property(e => e.ParentType).HasColumnName("parent_type");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<WpNf3Upgrade>(entity =>
            {
                entity.ToTable("wp_nf3_upgrades");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Cache).HasColumnName("cache");

                entity.Property(e => e.Maintenance)
                    .HasColumnType("bit(1)")
                    .HasColumnName("maintenance")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.Stage)
                    .HasColumnType("int(11)")
                    .HasColumnName("stage");
            });

            modelBuilder.Entity<WpOption>(entity =>
            {
                entity.HasKey(e => e.OptionId)
                    .HasName("PRIMARY");

                entity.ToTable("wp_options");

                entity.UseCollation("utf8mb4_unicode_520_ci");

                entity.HasIndex(e => e.Autoload, "autoload");

                entity.HasIndex(e => e.OptionName, "option_name")
                    .IsUnique();

                entity.Property(e => e.OptionId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("option_id");

                entity.Property(e => e.Autoload)
                    .HasMaxLength(20)
                    .HasColumnName("autoload")
                    .HasDefaultValueSql("'yes'");

                entity.Property(e => e.OptionName)
                    .HasMaxLength(191)
                    .HasColumnName("option_name")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OptionValue).HasColumnName("option_value");
            });

            modelBuilder.Entity<WpPost>(entity =>
            {
                entity.ToTable("wp_posts");

                entity.UseCollation("utf8mb4_unicode_520_ci");

                entity.HasIndex(e => e.PostAuthor, "post_author");

                entity.HasIndex(e => e.PostName, "post_name")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 191 });

                entity.HasIndex(e => e.PostParent, "post_parent");

                entity.HasIndex(e => new { e.PostType, e.PostStatus, e.PostDate, e.Id }, "type_status_date");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("ID");

                entity.Property(e => e.CommentCount)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("comment_count");

                entity.Property(e => e.CommentStatus)
                    .HasMaxLength(20)
                    .HasColumnName("comment_status")
                    .HasDefaultValueSql("'open'");

                entity.Property(e => e.Guid)
                    .HasMaxLength(255)
                    .HasColumnName("guid")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MenuOrder)
                    .HasColumnType("int(11)")
                    .HasColumnName("menu_order");

                entity.Property(e => e.PingStatus)
                    .HasMaxLength(20)
                    .HasColumnName("ping_status")
                    .HasDefaultValueSql("'open'");

                entity.Property(e => e.Pinged)
                    .HasColumnType("text")
                    .HasColumnName("pinged");

                entity.Property(e => e.PostAuthor)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("post_author");

                entity.Property(e => e.PostContent).HasColumnName("post_content");

                entity.Property(e => e.PostContentFiltered).HasColumnName("post_content_filtered");

                entity.Property(e => e.PostDate)
                    .HasColumnType("datetime")
                    .HasColumnName("post_date")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.PostDateGmt)
                    .HasColumnType("datetime")
                    .HasColumnName("post_date_gmt")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.PostExcerpt)
                    .HasColumnType("text")
                    .HasColumnName("post_excerpt");

                entity.Property(e => e.PostMimeType)
                    .HasMaxLength(100)
                    .HasColumnName("post_mime_type")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PostModified)
                    .HasColumnType("datetime")
                    .HasColumnName("post_modified")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.PostModifiedGmt)
                    .HasColumnType("datetime")
                    .HasColumnName("post_modified_gmt")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.PostName)
                    .HasMaxLength(200)
                    .HasColumnName("post_name")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PostParent)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("post_parent");

                entity.Property(e => e.PostPassword)
                    .HasMaxLength(255)
                    .HasColumnName("post_password")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PostStatus)
                    .HasMaxLength(20)
                    .HasColumnName("post_status")
                    .HasDefaultValueSql("'publish'");

                entity.Property(e => e.PostTitle)
                    .HasColumnType("text")
                    .HasColumnName("post_title");

                entity.Property(e => e.PostType)
                    .HasMaxLength(20)
                    .HasColumnName("post_type")
                    .HasDefaultValueSql("'post'");

                entity.Property(e => e.ToPing)
                    .HasColumnType("text")
                    .HasColumnName("to_ping");
            });

            modelBuilder.Entity<WpPostmetum>(entity =>
            {
                entity.HasKey(e => e.MetaId)
                    .HasName("PRIMARY");

                entity.ToTable("wp_postmeta");

                entity.UseCollation("utf8mb4_unicode_520_ci");

                entity.HasIndex(e => e.MetaKey, "meta_key")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 191 });

                entity.HasIndex(e => e.PostId, "post_id");

                entity.Property(e => e.MetaId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("meta_id");

                entity.Property(e => e.MetaKey).HasColumnName("meta_key");

                entity.Property(e => e.MetaValue).HasColumnName("meta_value");

                entity.Property(e => e.PostId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("post_id");
            });

            modelBuilder.Entity<WpTerm>(entity =>
            {
                entity.HasKey(e => e.TermId)
                    .HasName("PRIMARY");

                entity.ToTable("wp_terms");

                entity.UseCollation("utf8mb4_unicode_520_ci");

                entity.HasIndex(e => e.Name, "name")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 191 });

                entity.HasIndex(e => e.Slug, "slug")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 191 });

                entity.Property(e => e.TermId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("term_id");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .HasColumnName("name")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Slug)
                    .HasMaxLength(200)
                    .HasColumnName("slug")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.TermGroup)
                    .HasColumnType("bigint(10)")
                    .HasColumnName("term_group");
            });

            modelBuilder.Entity<WpTermRelationship>(entity =>
            {
                entity.HasKey(e => new { e.ObjectId, e.TermTaxonomyId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("wp_term_relationships");

                entity.UseCollation("utf8mb4_unicode_520_ci");

                entity.HasIndex(e => e.TermTaxonomyId, "term_taxonomy_id");

                entity.Property(e => e.ObjectId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("object_id");

                entity.Property(e => e.TermTaxonomyId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("term_taxonomy_id");

                entity.Property(e => e.TermOrder)
                    .HasColumnType("int(11)")
                    .HasColumnName("term_order");
            });

            modelBuilder.Entity<WpTermTaxonomy>(entity =>
            {
                entity.HasKey(e => e.TermTaxonomyId)
                    .HasName("PRIMARY");

                entity.ToTable("wp_term_taxonomy");

                entity.UseCollation("utf8mb4_unicode_520_ci");

                entity.HasIndex(e => e.Taxonomy, "taxonomy");

                entity.HasIndex(e => new { e.TermId, e.Taxonomy }, "term_id_taxonomy")
                    .IsUnique();

                entity.Property(e => e.TermTaxonomyId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("term_taxonomy_id");

                entity.Property(e => e.Count)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("count");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Parent)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("parent");

                entity.Property(e => e.Taxonomy)
                    .HasMaxLength(32)
                    .HasColumnName("taxonomy")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.TermId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("term_id");
            });

            modelBuilder.Entity<WpTermmetum>(entity =>
            {
                entity.HasKey(e => e.MetaId)
                    .HasName("PRIMARY");

                entity.ToTable("wp_termmeta");

                entity.UseCollation("utf8mb4_unicode_520_ci");

                entity.HasIndex(e => e.MetaKey, "meta_key")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 191 });

                entity.HasIndex(e => e.TermId, "term_id");

                entity.Property(e => e.MetaId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("meta_id");

                entity.Property(e => e.MetaKey).HasColumnName("meta_key");

                entity.Property(e => e.MetaValue).HasColumnName("meta_value");

                entity.Property(e => e.TermId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("term_id");
            });

            modelBuilder.Entity<WpUser>(entity =>
            {
                entity.ToTable("wp_users");

                entity.UseCollation("utf8mb4_unicode_520_ci");

                entity.HasIndex(e => e.UserEmail, "user_email");

                entity.HasIndex(e => e.UserLogin, "user_login_key");

                entity.HasIndex(e => e.UserNicename, "user_nicename");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("ID");

                entity.Property(e => e.DisplayName)
                    .HasMaxLength(250)
                    .HasColumnName("display_name")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.UserActivationKey)
                    .HasMaxLength(255)
                    .HasColumnName("user_activation_key")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.UserEmail)
                    .HasMaxLength(100)
                    .HasColumnName("user_email")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.UserLogin)
                    .HasMaxLength(60)
                    .HasColumnName("user_login")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.UserNicename)
                    .HasMaxLength(50)
                    .HasColumnName("user_nicename")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.UserPass)
                    .HasMaxLength(255)
                    .HasColumnName("user_pass")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.UserRegistered)
                    .HasColumnType("datetime")
                    .HasColumnName("user_registered")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.UserStatus)
                    .HasColumnType("int(11)")
                    .HasColumnName("user_status");

                entity.Property(e => e.UserUrl)
                    .HasMaxLength(100)
                    .HasColumnName("user_url")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<WpUsermetum>(entity =>
            {
                entity.HasKey(e => e.UmetaId)
                    .HasName("PRIMARY");

                entity.ToTable("wp_usermeta");

                entity.UseCollation("utf8mb4_unicode_520_ci");

                entity.HasIndex(e => e.MetaKey, "meta_key")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 191 });

                entity.HasIndex(e => e.UserId, "user_id");

                entity.Property(e => e.UmetaId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("umeta_id");

                entity.Property(e => e.MetaKey).HasColumnName("meta_key");

                entity.Property(e => e.MetaValue).HasColumnName("meta_value");

                entity.Property(e => e.UserId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("user_id");
            });

            modelBuilder.Entity<WpWpformsPayment>(entity =>
            {
                entity.ToTable("wp_wpforms_payments");

                entity.UseCollation("utf8mb4_unicode_520_ci");

                entity.HasIndex(e => e.CustomerId, "customer_id")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 32 });

                entity.HasIndex(e => e.FormId, "form_id");

                entity.HasIndex(e => e.Status, "status")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 8 });

                entity.HasIndex(e => e.SubscriptionId, "subscription_id")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 32 });

                entity.HasIndex(e => e.SubscriptionStatus, "subscription_status")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 8 });

                entity.HasIndex(e => e.Title, "title")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 64 });

                entity.HasIndex(e => e.TotalAmount, "total_amount");

                entity.HasIndex(e => e.TransactionId, "transaction_id")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 32 });

                entity.HasIndex(e => e.Type, "type")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 8 });

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");

                entity.Property(e => e.Currency)
                    .HasMaxLength(3)
                    .HasColumnName("currency")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CustomerId)
                    .HasMaxLength(40)
                    .HasColumnName("customer_id")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.DateCreatedGmt)
                    .HasColumnType("datetime")
                    .HasColumnName("date_created_gmt");

                entity.Property(e => e.DateUpdatedGmt)
                    .HasColumnType("datetime")
                    .HasColumnName("date_updated_gmt");

                entity.Property(e => e.DiscountAmount)
                    .HasPrecision(26, 8)
                    .HasColumnName("discount_amount");

                entity.Property(e => e.EntryId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("entry_id");

                entity.Property(e => e.FormId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("form_id");

                entity.Property(e => e.Gateway)
                    .HasMaxLength(20)
                    .HasColumnName("gateway")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.IsPublished)
                    .IsRequired()
                    .HasColumnName("is_published")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Mode)
                    .HasMaxLength(4)
                    .HasColumnName("mode")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Status)
                    .HasMaxLength(10)
                    .HasColumnName("status")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.SubscriptionId)
                    .HasMaxLength(40)
                    .HasColumnName("subscription_id")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.SubscriptionStatus)
                    .HasMaxLength(10)
                    .HasColumnName("subscription_status")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.SubtotalAmount)
                    .HasPrecision(26, 8)
                    .HasColumnName("subtotal_amount");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.TotalAmount)
                    .HasPrecision(26, 8)
                    .HasColumnName("total_amount");

                entity.Property(e => e.TransactionId)
                    .HasMaxLength(40)
                    .HasColumnName("transaction_id")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Type)
                    .HasMaxLength(12)
                    .HasColumnName("type")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<WpWpformsPaymentMetum>(entity =>
            {
                entity.ToTable("wp_wpforms_payment_meta");

                entity.UseCollation("utf8mb4_unicode_520_ci");

                entity.HasIndex(e => e.MetaKey, "meta_key")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 191 });

                entity.HasIndex(e => e.MetaValue, "meta_value")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 191 });

                entity.HasIndex(e => e.PaymentId, "payment_id");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");

                entity.Property(e => e.MetaKey).HasColumnName("meta_key");

                entity.Property(e => e.MetaValue)
                    .HasColumnType("longtext")
                    .HasColumnName("meta_value");

                entity.Property(e => e.PaymentId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("payment_id");
            });

            modelBuilder.Entity<WpWpformsTasksMetum>(entity =>
            {
                entity.ToTable("wp_wpforms_tasks_meta");

                entity.UseCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");

                entity.Property(e => e.Action)
                    .HasMaxLength(255)
                    .HasColumnName("action");

                entity.Property(e => e.Data).HasColumnName("data");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("date");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
