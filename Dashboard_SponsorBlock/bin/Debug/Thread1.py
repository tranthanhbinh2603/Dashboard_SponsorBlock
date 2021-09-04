from pytube import YouTube
YouTube("https://www.youtube.com/watch?v=NDcNls1sobs").streams.filter(resolution='360p', progressive=True, file_extension='mp4').first().download(output_path="D:\Test Dashboard SponsorBlock\VideoDownload", filename="NDcNls1sobs.mp4")
YouTube("https://www.youtube.com/watch?v=oAWATQHKUnM").streams.filter(resolution='360p', progressive=True, file_extension='mp4').first().download(output_path="D:\Test Dashboard SponsorBlock\VideoDownload", filename="oAWATQHKUnM.mp4")
YouTube("https://www.youtube.com/watch?v=nuJA8UgsEWs").streams.filter(resolution='360p', progressive=True, file_extension='mp4').first().download(output_path="D:\Test Dashboard SponsorBlock\VideoDownload", filename="nuJA8UgsEWs.mp4")
YouTube("https://www.youtube.com/watch?v=tSb_XpNb-tw").streams.filter(resolution='360p', progressive=True, file_extension='mp4').first().download(output_path="D:\Test Dashboard SponsorBlock\VideoDownload", filename="tSb_XpNb-tw.mp4")
YouTube("https://www.youtube.com/watch?v=q9vpFX9kRKY").streams.filter(resolution='360p', progressive=True, file_extension='mp4').first().download(output_path="D:\Test Dashboard SponsorBlock\VideoDownload", filename="q9vpFX9kRKY.mp4")
