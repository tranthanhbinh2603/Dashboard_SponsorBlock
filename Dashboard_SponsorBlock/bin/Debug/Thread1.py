from pytube import YouTube
YouTube("https://www.youtube.com/watch?v=oAWATQHKUnM").streams.filter(resolution='360p', progressive=True, file_extension='mp4').first().download(output_path="D:\Test Dashboard SponsorBlock\VideoDownload", filename="oAWATQHKUnM.mp4")
YouTube("https://www.youtube.com/watch?v=nuJA8UgsEWs").streams.filter(resolution='360p', progressive=True, file_extension='mp4').first().download(output_path="D:\Test Dashboard SponsorBlock\VideoDownload", filename="nuJA8UgsEWs.mp4")
