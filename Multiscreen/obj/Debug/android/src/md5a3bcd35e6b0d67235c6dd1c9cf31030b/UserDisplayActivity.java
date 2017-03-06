package md5a3bcd35e6b0d67235c6dd1c9cf31030b;


public class UserDisplayActivity
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("Multiscreen.UserDisplayActivity, Multiscreen, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", UserDisplayActivity.class, __md_methods);
	}


	public UserDisplayActivity () throws java.lang.Throwable
	{
		super ();
		if (getClass () == UserDisplayActivity.class)
			mono.android.TypeManager.Activate ("Multiscreen.UserDisplayActivity, Multiscreen, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
