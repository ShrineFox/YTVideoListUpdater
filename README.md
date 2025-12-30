# YTVideoListUpdater
Uses YT-DLP to fetch a list of YouTube video URLs and Titles from a YouTube channel, and download them in ascending order.  
![](https://i.imgur.com/L2B0Oeo.png)  
Download the latest builds via the [Releases page](https://github.com/ShrineFox/YTVideoListUpdater/releases).

# Usage
1. Edit ``settings.json``. Add your YouTube channel's name and Channel ID to the list.  
2. In the ``Settings`` tab, choose an output folder for downloaded videos.
3. Also set the path to ``ffmpeg.exe`` if you have it, since this will improve video quality.
4. Head to the ``Updater`` tab and click the button to update ``yt-dlp.exe`` for best compatibility.
5. Also choose the YouTube channel from the list that you want to download from, and click the button to download an updated video list.
6. Head to the ``Channel`` tab in the ``Downloader`` tab, and select the YouTube channel that you want to download from.
7. Select a video from the list to download. Click the "download video" button to download only that video.
8. If you want to download all videos starting from the one you have selected in the list, click the other download button.
9. Close the program when you want to stop downloading. YT-DLP will finish downloading the last video it was working on in a separate window.

# Resuming Downloads
1. On subsequent launches, in the ``Downloader`` tab's ``Channel`` tab, select the channel you were downloading from previously.
2. Click on ``Tools > Check Missing Videos`` and choose the folder where you were outputting downloaded videos to.
3. A ``.tsv`` file will be generated with a list of all the videos already downloaded so far. You can load that list from the ``Tools`` menu to resume next time.
4. Now when you choose to "Download All Videos" from a channel, it will skip trying to download videos that were already downloaded, thus saving you time.

# Troubleshooting
Sometimes you may end up getting rate limited or blocked from downloading videos.  
This happens if you download too many within a short period of time, and your activity gets flagged as automated behavior.  
One workaround is to log into your YouTube account on FireFox, and then in the ``Settings`` tab, choose ``FireFox`` as the browser to get cookies from.  
This will also help you download Age Restricted videos, which would otherwise be skipped by default.
