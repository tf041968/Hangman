//Johan Persson
//tf041968 - Malmö Högskola
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inl_uppg_3
{
	class Hang
	{
		private string[] words = { "etta", "tv", "tre" };
		private string guessedChars = "";
		private string result ="";
		private string randomWordToGuess;
		private int numberOfErrors;
		private int numberOfGuesses;

		public Hang()
		{ 
			Random random = new Random();
			int index = random.Next(0, words.Count());
			randomWordToGuess = words[index];
		}

		/// <summary>
		/// Kollar om gissad bokstav redan har gissast. 
		/// Om den finns resulterat false. 
		/// Om den inte blivit gissad så kontrolleras det om den finns i ordet som ska gissas eller ej. 
		/// </summary>
		/// <param name="guessedChar">Gissad bokstav</param>
		/// <returns>True om bokstaven inte gissats tidigare, false om den redan är gissad.</returns>
		public bool isCharNotGuessed(string guessedChar) //Metod som tar emot gissade bokstaven och kollar om den finns i ordet. 
		{
			if (guessedChars.Contains(guessedChar))//Om gissadebokstäver innehåller den gissade bokstaven
			{
				return false;
			}
			else    //Om bokstaven inte tidigare blivit gissad. 
			{
				if (randomWordToGuess.Contains(guessedChar))//Om det genererade ordet innehåller bokstaven
				{
					result = "";
					bool bokstavFinns = false;
					guessedChars += guessedChar;

					//Kollar om den gissade bokstaven finns och sätter bool true isf.
					for (int i = 0; i < randomWordToGuess.Length; i++)      //Loopar ordet att gissa
					{
						for (int j = 0; j < guessedChars.Length; j++)       //Loopar alla tecken som gissats
						{
							if (randomWordToGuess[i] == guessedChars[j]) 
							{
								bokstavFinns = true;
								break;
							}
						}

						if (bokstavFinns) //Om bokstaven finns(bool true) uppdatera resultat med bokstav
						{
							result = result + randomWordToGuess[i];
							bokstavFinns = false;
						}
						else //Skriv streck
						{
							result = result + "-";
						}
					}
					numberOfGuesses++; //Uppdatera antal gissningar. 
					return true;
				}
				//Körs om det genererade ordet INTE innehåller den gissade bokstaven. 
				//Ökar felgissningar och totala antalet gissningar.
				else 
				{
					guessedChars += guessedChar;
					numberOfGuesses++;
					numberOfErrors++;
					return true;
				}
			}
		}
		
		/// <summary>
		/// Kollar om man klarat spelet
		/// </summary>
		/// <returns>True om spelet är avklarat eller false om det inte är avklart.</returns>
		public bool KlaratSpel()
		{
			if (randomWordToGuess == result)// Om genererade ordet är lika med resultatet så har man vunnit. 
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// Skapar understreck för att dölja ordet. 
		/// </summary>
		public void SkapaStreck()
		{
			for (int i = 0; i < randomWordToGuess.Length; i++)
			{
				result += "-";
			}
		
		}
		
		/// <summary>
		/// Startar nytt spel
		/// </summary>
		public void NyttSpel()
		{
			result ="";
			numberOfErrors = 0;
			numberOfGuesses = 0;
			SkapaStreck();
			
		}


		//Properties för strings och int. 
		public string Resultat
		{
			get { return result; }
		}

		public string GissadeBokstäver
		{
			get { return guessedChars;  }
			set { guessedChars = value; }
		}

		public int AntalGissningar
		{
			get { return numberOfGuesses; }
		}

		public int AntalFel
		{
			get { return numberOfErrors; }
		}
	}
}
