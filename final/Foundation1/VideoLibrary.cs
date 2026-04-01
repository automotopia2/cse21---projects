using System;

class VideoLibrary
{
    // Variables
    private List<Video> _videos = new List<Video>(); 
    // Methods
    public void AddVideo(Video video)
    {
        _videos.Add(video);
    }
    
    public void DisplayVideos()
    {
        foreach (Video video in _videos)
        {
            video.DisplayVideo();
        }
    }
}