package md52cbbb386ce1d336d1e7fd8910a8d96d8;


public class GcmService
	extends md5888b830801eb5e3841ccc5799e6c789e.GcmServiceBase
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("Xamarin.Forms.CommonCore.GcmService, referenceguide.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", GcmService.class, __md_methods);
	}


	public GcmService (java.lang.String p0) throws java.lang.Throwable
	{
		super (p0);
		if (getClass () == GcmService.class)
			mono.android.TypeManager.Activate ("Xamarin.Forms.CommonCore.GcmService, referenceguide.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "System.String, mscorlib, Version=2.0.5.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e", this, new java.lang.Object[] { p0 });
	}


	public GcmService () throws java.lang.Throwable
	{
		super ();
		if (getClass () == GcmService.class)
			mono.android.TypeManager.Activate ("Xamarin.Forms.CommonCore.GcmService, referenceguide.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

	public GcmService (java.lang.String[] p0) throws java.lang.Throwable
	{
		super ();
		if (getClass () == GcmService.class)
			mono.android.TypeManager.Activate ("Xamarin.Forms.CommonCore.GcmService, referenceguide.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "System.String[], mscorlib, Version=2.0.5.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e", this, new java.lang.Object[] { p0 });
	}

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