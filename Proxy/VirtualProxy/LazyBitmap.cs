using VirtualProxy.Interfaces;

namespace VirtualProxy;

public class LazyBitmap : IBitmap
{
    private readonly string filename;
    private Bitmap bitmap;
    
    public LazyBitmap(string filename)
    {
        this.filename = filename;
    }
    
    public void Draw()
    {
        if (bitmap == null)
        {
            bitmap = new Bitmap(filename);
        }
        
        bitmap.Draw();
    }
}