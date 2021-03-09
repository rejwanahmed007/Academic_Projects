class MovieInfo
{
	private int movieID;
	private String movieName,genre,releaseDate,runningTime,rating;
	
	public MovieInfo(int mID,String mName,String mGenre,String mReleaseDate,String mRunningTime,String mRating)
	{
		this.movieID=mID;
		this.movieName=mName;
		this.genre=mGenre;
		this.releaseDate=mReleaseDate;
		this.runningTime=mRunningTime;
		this.rating=mRating;
	}
	public void setMovieID(int mID){this.movieID=mID;}
	public void setMovieName(String mName){this.movieName=mName;}
	public void setGenre(String mGenre){this.genre=mGenre;}
	public void setReleaseDate(String mReleaseDate){this.releaseDate=mReleaseDate;}
	public void setRunningTime(String mRunningTime){this.runningTime=mRunningTime;}
	public void setRating(String mRating){this.rating=mRating;}
	public int getMovieID(){return movieID;}
	public String getMovieName(){return movieName;}
	public String getGenre(){return genre;}
	public String getReleaseDate(){return releaseDate;}
	public String getRunningTime(){return runningTime;}
	public String getRating(){return rating;}
}