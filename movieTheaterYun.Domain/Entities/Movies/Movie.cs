using movieTheaterYun.Domain.Commons;
using movieTheaterYun.Domain.Entities.Showtimes;
using movieTheaterYun.Domain.Enums;
namespace movieTheaterYun.Domain.Entities.Movies
{
    public class Movie : EntityAuditBase
    {
        public string Name { get; set; }
        public AgeRating AgeRating { get; set; }
        public int RuntimeMin {  get; set; }
        public DateTimeOffset ReleaseDate { get; set; }
        public string? TrailerLink { get; set; }
        public string? Description { get; set; }
        public string? HeaderImage { get; set; }
        public string? BannerImage { get; set; }
        public string? Director { get; set; }
        public string? Actor { get; set; }

        #region Relationship
        public virtual ICollection<Genre> Genres { get; set; }
        public virtual ICollection<Showtime>? Showtimes { get; set; }
        #endregion
    }
    public class Genre : EntityAuditBase
    {
        public string Name { get; set; }

        #region Relationship
        public virtual ICollection<Movie>? Movies { get; set; }
        #endregion

    }

}
