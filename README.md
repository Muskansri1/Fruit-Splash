# Introduction
- The assignment features a website that features a dashboard which displays all the conecpts we've learned in the Web Design class. It uses concepts of CSS like Grid Box and Flex Box.
- The webpages have also incorporated various SASS/SCSS Features like Variables, Custom Properties, Nesting, Interpolation, Placeholder Selectors, Mixins, Functions.

## Requirements
1. Create a two-page website of your favorite Concept. You can use the same as Assignment-01 or develop a new one.
2. The assignment aims to learn about CSS Grid layout/Flexbox and SASS/SCSS Features.
3. Implement a CSS Grid and a flexbox in your pages wherever it fits.
4. Implement All the below SASS Features: Variables, Custom Properties, Nesting, Interpolation, Placeholder Selectors, Mixins, Functions. Feel free to use more SASS/SCSS Features.
5. SASS/SCSS Files need to be organized into multiple files based on UI Features, Common Elements or Themes
6. UI Should be Rich and will be considered for grading
7. A Readme file should be included explaining the features implemented and how and where in your pages they were implemented.

## In-Depth Explanation of the Features Used:
1. The Dashboard is vreated using the Grid Layout of CSS.
2. The Tech stack component uses the flexbox property of CSS.
3. The Explore and and Module pages of the Dashboard also follow the Grid Layout property of CSS.
4. Variables: Sass variables are a feature of the Sass (Syntactically Awesome Style Sheets) preprocessor that allows you to define and store values that can be reused throughout your stylesheet. Sass variables are defined using the $ symbol. The advantage of using Sass variables is that they make it easy to maintain a consistent look and feel throughout your site. The Sass variable in the dashboard is used to define custom colors and have been utilized in the entire web-page.
- eg: 
```
$light-grey: #808191;
$background-color :  #22b07d;
```
5. Custom Properties: CSS custom properties, also known as CSS variables, have an unusual declaration syntax: they allow almost any text at all in their declaration values. 
- eg:
```
:root {
  --body-font: "Inter", sans-serif;
  --theme-bg: #1f1d2b;
  --body-color: #808191;
  --button-bg: #353340;
  --border-color: rgb(128 129 145 / 24%);
  --video-bg: #252936;
  --delay: 0s;
 }

 .video {
    position: relative;
    background-color: var(--video-bg);
 }
 ```
6. Nesting: Sass nesting is a feature of the Sass (Syntactically Awesome Style Sheets) preprocessor that allows you to write more organized and readable CSS code by nesting selectors and styles within one another. With Sass nesting, you can group related styles together, making your code more modular and easier to maintain
- eg: 
```
.container-card {
    #{$w}: 100%;
    height: 60vh;
      
    .gallery {
      #{$w}: 100%;
      height: 100%;
      margin: 0 auto;
      margin-top: 5%;
      display: flex;
      align-items: top;
      gap: 10px;
      .card {
        position: relative;
        // position: top;
        height: 400px;
        flex: 1;
        overflow: hidden;
        border-radius: 15px;
        cursor: pointer;
        filter: grayscale(80%);
        transition: all 0.8s cubic-bezier(0.25, 0.4, 0.45, 1.4);
        img {
            #{$w}: 100%;
          height: 100%;
          object-fit: cover;
          object-position: center;
        }
        .info {
            #{$w}: 500px;
          position: absolute;
          color: white;
          z-index: 3;
          padding: 15px;
          bottom: 0;
          opacity: 0;
          transition: opacity 1.5s cubic-bezier(0.25, 0.4, 0.45, 1.4);
          box-shadow: inset 0 -120px 120px -120px black,
            inset 0 -120px 120px -120px black;
        }
        &:hover {
          flex: 5;
          filter: none;
          .info {
            opacity: 1;
          }
        }
      }
    }
  }

```
7. Interpolation: Interpolation is a feature in Sass (Syntactically Awesome Style Sheets) that allows you to dynamically generate CSS property names, selectors, and values using variable values or expressions. It is denoted by the #{} syntax.
- eg: 
```

$w: "width";

.container-card {
    #{$w}: 100%;
    height: 60vh;
      
    .gallery {
      #{$w}: 100%;
      height: 100%;
      margin: 0 auto;
      margin-top: 5%;
      display: flex;
      align-items: top;
      gap: 10px;
    }
}
```

8. Placeholder Selectors: In Sass (Syntactically Awesome Style Sheets), a placeholder selector is a type of selector that is defined using the % symbol instead of the usual selector syntax. Placeholder selectors do not generate any CSS output on their own. Instead, they are designed to be extended by other selectors using the @extend directive.
- eg: 
```
%body-values{
  width: 100%;
  height: 100%;
  overflow-x: hidden;
}

body,html{
  @extend %body-values;
  font-family: "Inter", sans-serif;
  margin-left: 0%;
  margin-top: 0%;
}

```
9. Mixins: In Sass (Syntactically Awesome Style Sheets), a mixin is a group of CSS declarations that can be reused throughout your codebase. Mixins are defined using the @mixin directive and can be included in other styles using the @include directive.
- eg: 
```
@mixin side-bar-section{
  width: 200px;
  padding: 32px;
  transition: 0.3s width ease-in-out;
}

.sidebar {
    @include side-bar-section;
  
    @media screen and (max-width: 1212px) {
      width: 30px;
      border-inline-end: 1px solid hsl(236deg 7% 54% / 25%);
    }
      
      @media screen and (max-width: 600px) {
      display: none;
    }
}
```
10. Functions: In Sass (Syntactically Awesome Style Sheets), functions are similar to mixins in that they allow you to define reusable blocks of code. 
- eg:
```
      background-color: darken($background-color, 10%);

```

## Credit/Acknowledgment
Muskan Srivastava
