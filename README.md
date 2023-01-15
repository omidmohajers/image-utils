# image-utils
A library for working with #images such as #resize #grayscale #save #convert on dotnet

While working with images, I collected some of its most used functions in the form of a library. Some of its commonly used methods:


// canverting physical image file to byte array for store in database 
    public static byte[] ToByte(string filename)

// load image from file
    public static Image FromFile(string fileName)

// save image to file
public static void Save(string fileName,Image img)

// convert image to byte array useful for store imagedata in database
public static byte[] ToByte(Image image)
public static byte[] ToByte(Image image, System.Drawing.Imaging.ImageFormat format)

// convert byte array to image fore restore image data from database
public static Image FromByteArray(byte[] buffer)

// make grayscale copy of image
public static Bitmap MakeGrayscale(Bitmap original)

// make colorful copy of image 
public static Image ConvertImageToARGB(Image img)

// zoom on part of image
public static Image ZoomImage(Image input, Rectangle zoomArea, Rectangle sourceArea)

// resize image 
public static Image ResizeImage(Image input, Size newSize, InterpolationMode interpolation)
