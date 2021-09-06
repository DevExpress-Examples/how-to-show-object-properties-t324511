Imports DevExpress.Mvvm
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Linq
Imports System.Text

Namespace DXSample
	Public Class ViewModel
		Public Property Items() As List(Of Contact)
		Public Sub New()
			Items = New List(Of Contact)() From {
				New Contact() With {
					.FirstName = "Carolyn",
					.LastName = "Baker",
					.Email = "carolyn.baker@example.com",
					.Phone = "(555)349-3010",
					.Address = "1198 Theresa Cir",
					.City = "Whitinsville",
					.State = "MA",
					.Zip = "01582"
				},
				New Contact() With {
					.FirstName = "Amber",
					.LastName = "Seaman",
					.Phone = "(555)698-4285",
					.Address = "28700 S Main St",
					.City = "Wilsonville",
					.State = "AL",
					.Zip = "35188"
				},
				New Contact() With {
					.FirstName = "Annie",
					.LastName = "Vicars",
					.Email = "annie.vicars@example.com",
					.Phone = "(555)922-1349",
					.Address = "7267 New York Ave",
					.City = "Jersey City",
					.State = "NJ",
					.Zip = "07306"
				},
				New Contact() With {
					.FirstName = "Darlene",
					.LastName = "Catto",
					.Email = "darlene.catto@example.com",
					.Phone = "(555)752-0582",
					.Address = "32125 4th St NW #210",
					.City = "Washington",
					.State = "DC",
					.Zip = "20001"
				},
				New Contact() With {
					.FirstName = "Angela",
					.LastName = "Gross",
					.Email = "angela.gross@example.com",
					.Phone = "(555)247-1252",
					.Address = "8723 Chicago Ave",
					.City = "Nederland",
					.State = "TX",
					.Zip = "77620"
				}
			}
		End Sub
	End Class
	Public Class Contact
		Inherits BindableBase

		Private _FirstName As String
		Public Property FirstName() As String
			Get
				Return _FirstName
			End Get
			Set(ByVal value As String)
				_FirstName = value
				RaisePropertyChanged(Function() FirstName)
			End Set
		End Property

		Private _LastName As String
		Public Property LastName() As String
			Get
				Return _LastName
			End Get
			Set(ByVal value As String)
				_LastName = value
				RaisePropertyChanged(Function() LastName)
			End Set
		End Property

		Private _Email As String
		Public Property Email() As String
			Get
				Return _Email
			End Get
			Set(ByVal value As String)
				_Email = value
				RaisePropertyChanged(Function() Email)
			End Set
		End Property

		Private _Phone As String
		Public Property Phone() As String
			Get
				Return _Phone
			End Get
			Set(ByVal value As String)
				_Phone = value
				RaisePropertyChanged(Function() Phone)
			End Set
		End Property

		Private _Address As String
		Public Property Address() As String
			Get
				Return _Address
			End Get
			Set(ByVal value As String)
				_Address = value
				RaisePropertyChanged(Function() Address)
			End Set
		End Property

		Private _City As String
		Public Property City() As String
			Get
				Return _City
			End Get
			Set(ByVal value As String)
				_City = value
				RaisePropertyChanged(Function() City)
			End Set
		End Property

		Private _State As String
		Public Property State() As String
			Get
				Return _State
			End Get
			Set(ByVal value As String)
				_State = value
				RaisePropertyChanged(Function() State)
			End Set
		End Property

		Private _Zip As String
		Public Property Zip() As String
			Get
				Return _Zip
			End Get
			Set(ByVal value As String)
				_Zip = value
				RaisePropertyChanged(Function() Zip)
			End Set
		End Property
	End Class
End Namespace