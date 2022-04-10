<div id="top"></div>

[![LinkedIn][linkedin-shield]][linkedin-url]



<!-- PROJECT LOGO -->
 

<br />
<div align="center">
  <a href="https://github.com/victorcappa/Live-Album">
    <img src="images/logo.png" alt="Logo" width="80" height="80">
  </a>

<h3 align="center">Live Album</h3>

  <p align="center">
    This is a simple AR image tracking video player, based on AR Foundation, ARKit, utilizing Unity and C#.
    <br />

 Demo video can be seem here - https://rb.gy/puka1z

  </p>
</div>


<!-- TABLE OF CONTENTS -->
<details>
  <summary>Table of Contents</summary>
  <ol>
    <li>
      <a href="#about-the-project">About The Project</a>
      <ul>
        <li><a href="#built-with">Built With</a></li>
      </ul>
    </li>
    <li>
      <a href="#getting-started">Getting Started</a>
      <ul>
        <li><a href="#prerequisites">Prerequisites</a></li>
        <li><a href="#installation">Installation</a></li>
      </ul>
    </li>
    <li><a href="#usage">Usage</a></li>
    <li><a href="#roadmap">Roadmap</a></li>
    <li><a href="#contributing">Contributing</a></li>
    <li><a href="#license">License</a></li>
    <li><a href="#contact">Contact</a></li>
    <li><a href="#acknowledgments">Acknowledgments</a></li>
  </ol>
</details>



<!-- ABOUT THE PROJECT -->
## About The Project

<p align="center">
  <img src="https://user-images.githubusercontent.com/40408965/162596419-2291f563-9caa-4a7d-b271-d2e2728481fb.gif" alt="animated" />
</p>


<p align="right">(<a href="#top">back to top</a>)</p>



### Built With

* [Unity3d](https://unity.com/)
* [AR Foundation](https://docs.unity3d.com/Manual/com.unity.xr.arfoundation.html)
* [AR Kit](https://developer.apple.com/augmented-reality/)

<p align="right">(<a href="#top">back to top</a>)</p>



<!-- GETTING STARTED -->
## Getting Started

Download the project and open it with Unity version 2021.2.18f or latest. 
Below you can see some steps on how to create this project yourself.

### Prerequisites

Unity version 2021.2.18f or latest;
AR Foundation package;
A photograf or any other image;
A video source (can be a link).

### Installation

<div align="left">
 
1 - Open your project and inside the package manager, install the AR Foundation package:<br>


 
<br><img style="padding: 10px" width="800" alt="install AR Foundation" src="https://user-images.githubusercontent.com/40408965/162599285-fe5b0490-256c-4626-8f54-9a9a1868b926.png"><br>



 2 - On Player Settings, check the plug-in providers (ARKit for IOS or ARCore for Android)<br>

 <img width="800" alt="Plug-in Providers ARKit" src="https://user-images.githubusercontent.com/40408965/162599450-526cddc2-cb64-411f-b85e-04018fab7a9f.png">



<br> 3 - Setup the scene for AR:<br>


<img width="300" alt="Captura de Tela 2022-04-10 às 00 17 20" src="https://user-images.githubusercontent.com/40408965/162599897-89a9eeee-46b9-4294-bab0-7d258f780f42.png">

<img width="800" alt="Captura de Tela 2022-04-10 às 00 17 30" src="https://user-images.githubusercontent.com/40408965/162599901-5d1b8c8e-a3a2-40d4-b59e-ed3ea85eb4c4.png">
 
 
 <br> 4 - Create a ParentPrefab and inside it, a plane and a VideoPlayer object with a Video Player component;
 
 <br> 5 - Use the image to be tracked as the plane's material;
 
 <br> 6 - Create a 3D button inside the ParentPrefab, containing a Sphere with glass material and two text mesh pro elements for the play/pause symbols;
 
 <img width="600" alt="Captura de Tela 2022-04-10 às 00 36 50" src="https://user-images.githubusercontent.com/40408965/162600401-36ced730-435d-41dd-9966-2a9930e89466.png">
 
 <br> 7 - Create the animations for the Play/Pause functions and add the VideoAnimControl script to the ParentPrefab;
 
 <br> 8 - Add the Ar Button Script to the Sphere object and set VideoPlayer as the Vp element;
 
 <br> 9 - Create a canvas with a a button. Set ARSession.Reset to it (so you can restart the tracking session)

 <br> 10 - Create a XRReferenceImageLibrary, referencing it to the image to be tracked. Add it as the Serialized Library, in the AR Tracked Image Manager (AR Session Origin). 
 
<img width="299" alt="XRReferenceImageLibrary" src="https://user-images.githubusercontent.com/40408965/162617118-98be02a4-256f-45ed-a0b6-6e2211b3ba28.png">
 
 </div>
 
[*Create a XRReferenceImageLibrary](https://docs.unity3d.com/Packages/com.unity.xr.arfoundation@5.0/manual/arsubsystems/image-tracking.html)


 
 <br><h3>Done!</h3>




<p align="right">(<a href="#top">back to top</a>)</p>



<!-- USAGE EXAMPLES -->
## Usage

To iterate the idea, you can create a multiple prefab / multiple tacked images version. Soon I will update the project with the possibility for the user to upload the media (images to be tracked and videos)

<p align="right">(<a href="#top">back to top</a>)</p>



<!-- ROADMAP -->
## Roadmap

- [x] Play/Pause Button
- [ ] Multiple images and videos
- [ ] User friendly

<p align="right">(<a href="#top">back to top</a>)</p>


<!-- CONTRIBUTING -->
## Contributing

Contributions are what make the open source community such an amazing place to learn, inspire, and create. Any contributions you make are **greatly appreciated**.

If you have a suggestion that would make this better, please fork the repo and create a pull request. You can also simply open an issue with the tag "enhancement".
Don't forget to give the project a star! Thanks again!

1. Fork the Project
2. Create your Feature Branch (`git checkout -b feature/AmazingFeature`)
3. Commit your Changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the Branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

<p align="right">(<a href="#top">back to top</a>)</p>



<!-- LICENSE -->
## License

Distributed under the MIT License. See `LICENSE.txt` for more information.

<p align="right">(<a href="#top">back to top</a>)</p>



<!-- CONTACT -->
## Contact

Reach out - [Victor Cappa](xrDev@victorcappa.com)

Share the project - [Live Album](https://github.com/victorcappa/LiveAlbum)

<p align="right">(<a href="#top">back to top</a>)</p>

[linkedin-shield]: https://img.shields.io/badge/-LinkedIn-black.svg?style=for-the-badge&logo=linkedin&colorB=555
[linkedin-url]: https://www.linkedin.com/in/victor-cappa-50839788/

