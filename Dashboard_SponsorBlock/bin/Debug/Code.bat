@echo off
scenedetect --input "D:\Test Dashboard SponsorBlock\VideoDownload\q9vpFX9kRKY.mp4" --output "D:\Out Synce\q9vpFX9kRKY.mp4\From 0 to 00-01-00" time --start 0 --end 00:01:00 detect-content list-scenes save-images
scenedetect --input "D:\Test Dashboard SponsorBlock\VideoDownload\q9vpFX9kRKY.mp4" --output "D:\Out Synce\q9vpFX9kRKY.mp4\From 00-12-00 to 00-15-00" time --start 00:12:00 --end 00:15:00 detect-content list-scenes save-images
scenedetect --input "D:\Test Dashboard SponsorBlock\VideoDownload\q9vpFX9kRKY.mp4" --output "D:\Out Synce\q9vpFX9kRKY.mp4\From 00-22-00 to end video" time --start 00:22:00 detect-content list-scenes save-images
scenedetect --input "D:\Test Dashboard SponsorBlock\VideoDownload\tSb_XpNb-tw.mp4" --output "D:\Out Synce\tSb_XpNb-tw.mp4" detect-content list-scenes save-images
