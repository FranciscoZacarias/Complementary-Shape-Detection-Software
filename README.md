# Complementary Shape Detection Software
Software to complement a 2 servo laser turret made with arduino uno

# Introduction
Windows forms application, using the .NET Framework and [EmguCV 3.1.0](http://www.emgu.com/wiki/files/3.1.0/document/html/8dee1f02-8c8a-4e37-87f4-05e10c39f27d.htm) to identify, through image processing, shapes or objects and aim a laser at them.

The following video is the base project on what this was built on. While it didn't have yet the detection software implemented, it was wired to move with data sent from my cursor to the arduino. 

[![IMAGE ALT TEXT](https://i.ytimg.com/vi/fKnLFIDZh9g/hqdefault.jpg?sqp=-oaymwEZCNACELwBSFXyq4qpAwsIARUAAIhCGAFwAQ==&rs=AOn4CLAp_g3-Pcuo87AjTRqTvk9Ct0T6Qg)](https://www.youtube.com/watch?v=fKnLFIDZh9g")

With this implementation, the input would be the detected shape's center coordinates times a constant found in the [Constants](https://github.com/FranciscoZacarias/Complementary-Shape-Detection-Software/blob/master/form1/Constants.cs). Note that these are hardcoded, meaning that I came up with them via trial and error, since it heavily dependent on my hardware setup (Distance between webcam and object).
