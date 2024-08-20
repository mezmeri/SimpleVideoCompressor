![image](https://github.com/user-attachments/assets/d7affe48-5b33-4880-bd2f-b0b758df9a0a)
A simple application that can take a video file (currently only supports .mp4) and compress it, so that the file size gets much, much smaller. I built it because the video files I record get too big to send on the platforms where I talk to my friends (Discord, Face etc), as these have a max file size limit of 25mb.

It's basically just a very simple wrapper for ffmpeg, which runs one command that uses H.265 / HEVC compression to achieve a smaller file size. :)
