using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Person
/// </summary>
public class Person {
    private String mFirstName, mLastName;
    private int mHeight;
    private List<String> mFriends;
    private String mEmail;

    public Person(String firstName, String lastName, int height, List<String> friends, String eMail) {
        this.firstName = firstName;
        this.lastName = lastName;
        this.height = height;
        this.friends = friends;
        this.eMail = eMail;
    }
    public List<String> friends {
        get {return mFriends;}
        set {mFriends = value; }
    }

    public String firstName { 
        get { return mFirstName; }
        set { mFirstName = value; }
    }
    public String lastName {
        get { return mLastName; }
        set { mLastName = value; }
    }

    public int height {
        get { return mHeight; }
        set { mHeight = value; }
    }
    public String eMail {
        get { return mEmail; }
        set { mEmail = value; }
    }


}