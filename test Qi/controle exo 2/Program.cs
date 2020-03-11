using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace controle_exo_2 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Saisissez le nombre de personne");
            int nombrePersonne = Convert.ToInt32(Console.ReadLine());
            int[] lesQi = new int[nombrePersonne];
            SaisirQi(lesQi);
            int lePlusStupide = PlusStupide(lesQi);
            Console.WriteLine(QiGroupe(lePlusStupide,nombrePersonne));
            Console.ReadLine();}
        static void SaisirQi(int[] lesQi){
            for (int i = 0; i < lesQi.Length; i++) {
                Console.WriteLine("Saisissez le Qi");
                lesQi[i]=Convert.ToInt32(Console.ReadLine());}}
        static int PlusStupide(int[] lesQi){
            int QiFaible = lesQi[0];
            for (int i = 0; i < lesQi.Length; i++) {
                if (QiFaible > lesQi[i]){
                    QiFaible = lesQi[i];}}
            return QiFaible;}
        static double QiGroupe(int lePlusStupide , int nombrePersonne){
            double qiGroupe;
            qiGroupe = lePlusStupide / nombrePersonne;
            return qiGroupe;}}}
