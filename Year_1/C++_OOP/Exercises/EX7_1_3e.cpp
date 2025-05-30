#define _CRT_SECURE_NO_WARNINGS

# include <iostream>

using namespace std;   

class Parent
{
public:
	Parent( void );
	Parent(const char *, const char * );
	Parent( Parent & );
	virtual ~Parent(void)
	{
		delete lastName;
		delete country;
	}
	char* getLastName( void );
	void setLastName( char * );

	virtual void answerName( void );
	virtual const char *getClassName(void);
	virtual void birthPlace(void);

protected:
	char *lastName;
	char *country;
};

class Child : public Parent
{
public:
	Child( void );
	Child( const char *, const char *, const char *, const char * );
	Child( Child & );
	virtual ~Child(void)
	{
		delete firstName;
		delete city;
	}
	char* getFirstName( void );
	void setFirstName( char * );

	virtual void answerName( void );
	virtual const char *getClassName(void);
	virtual void birthPlace(void);

protected:
	char *firstName;
	char *city;

};

class GrandChild : public Child
{
public:
	GrandChild( void );
	GrandChild( const char *, const char *, const char *, const char *, const char *, const char * );
	virtual ~GrandChild(void)
	{
		delete grandFatherName;
		delete addr;
	}

	virtual void answerName( void );
	virtual const char *getClassName(void);
	virtual void birthPlace(void);

private:
	char *grandFatherName;
	char *addr;
};

void main( void )
{

	Parent  *family[ 3 ];
	Parent *p = new Parent( "Ivanov", "BG" );
	Parent *c = new Child( "Ivanov", "BG", "Peter", "Ruse" );
	Parent *g = new GrandChild( "Ivanov", "BG", "George", "Varna", "Nick", "Topola 11" );
	family[ 0 ] = g;
	family[ 1 ] = p;
	family[ 2 ] = c;
	for (int index = 0; index < 3; index++)
	{
		cout << family[index]->getClassName() << endl;
		family[index]->answerName();
		family[index]->birthPlace();
		cout << endl;
	}

} // end main

Parent :: Parent( void )
{
	lastName = new char[ 5 ];
	strcpy( lastName, "None" );
	country = new char[5];
	strcpy(country, "None");

}

Parent :: Parent( const char *aLastName, const char *aCountry )
{
	lastName = new char[ strlen( aLastName ) + 1 ];
	strcpy( lastName, aLastName );
	country = new char[strlen(aCountry) + 1];
	strcpy(country, aCountry);

}

Parent :: Parent( Parent& aParent)
{
	lastName = new char[ strlen( aParent.lastName ) + 1 ];
	strcpy( lastName, aParent.lastName );
	country = new char[strlen(aParent.country) + 1];
	strcpy(country, aParent.country);
}

char* Parent :: getLastName( void )
{
	return lastName;
}

void Parent :: setLastName( char *aName )
{
	lastName = new char[ strlen( aName ) + 1 ];
	strcpy( lastName, aName );
}

void Parent :: answerName( void )
{
	cout << "My family name is: "<< lastName << endl;
}

const char *Parent::getClassName(void)
{
	return "Parent";
}

void Parent::birthPlace(void)
{
	cout << "My country is: " << country << endl;

}

Child :: Child( void )
{
	firstName = new char[ 5];
	strcpy( firstName, "None");
	city = new char[5];
	strcpy(city, "None");

}

Child :: Child( const char *aLastName, const char *aCountry, const char *aFirstName, const char *aCity ): Parent( aLastName, aCountry )
{
	firstName= new char[ strlen(aFirstName)+ 1];
	strcpy( firstName, aFirstName );
	city = new char[strlen(aCity) + 1];
	strcpy(city, aCity);
}

Child :: Child( Child& aChild )
{
	setLastName( aChild.getLastName());
	country = aChild.country;

	firstName = new char[ strlen(aChild.firstName ) + 1 ];
	strcpy( firstName, aChild.firstName );
	city = new char[strlen(aChild.city) + 1];
	strcpy(city, aChild.city);
}

char* Child :: getFirstName( void )
{
	return firstName;
}

void Child :: setFirstName( char *aName )
{
	firstName = new char[ strlen( aName ) + 1 ];
	strcpy(firstName, aName);
}

void Child :: answerName( void )
{
	Parent::answerName();
	cout << "My name is: "<< firstName << "\n";
}

const char *Child::getClassName(void)
{
	return "Child";
}

void Child::birthPlace(void)
{
	Parent::birthPlace();
	cout << "My city is: " << city << endl;
}

GrandChild::GrandChild( void )
{
	grandFatherName = new char[ 5];
	strcpy( grandFatherName, "None");
	addr = new char[5];
	strcpy(addr, "None");
}

GrandChild::GrandChild(const char *aLastName, const char *aCountry, const char *aFirstName, const char *aCity, const char *aGrandFatherName, const char * aAddr) 
			: Child( aLastName, aCountry, aFirstName, aCity )
{
	grandFatherName = new char[ strlen( aGrandFatherName ) + 1 ];
	strcpy( grandFatherName, aGrandFatherName );
	addr = new char[strlen(aAddr) + 1];
	strcpy(addr, aAddr);
}

void GrandChild :: answerName( void )
{
	Child::answerName();
	cout << "My grandfather's name is: " << grandFatherName << endl;
}

const char *GrandChild::getClassName(void)
{
	return "GrandChild";
}

void GrandChild::birthPlace(void)
{
	Child::birthPlace();
	cout << "My address is: " << addr << endl;
}