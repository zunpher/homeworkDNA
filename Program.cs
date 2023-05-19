using System;
namespace homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool allctrl = true;
            while (allctrl)
            {
                Console.Write("Input half of DNA line (base on nuecleotide base): ");
                string hDNA = Console.ReadLine();
                bool again = true;


                if (IsValidSequence(hDNA) == true)
                {
                    Console.WriteLine("Current half DNA sequence: {0}", hDNA);

                    while (again)
                    {
                        Console.Write("Do you want to replicate it ? (Y/N): ");
                        string repCTRL = Console.ReadLine();

                        switch (repCTRL)
                        {
                            case "Y":
                                again = false;
                                Console.WriteLine("Replicated half DNA sequence: {0}", ReplicateSeqeunce(hDNA));
                                break;

                            case "N":
                                again = false;
                                break;

                            default:
                                Console.WriteLine("Please input Y or N.");
                                break;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("That half DNA sequence is invalid.");
                }

                Console.Write("Do you want to process another sequence ? (Y/N): ");
                string processCTRL = Console.ReadLine();
                bool processSWCT = true;

                while (processSWCT)
                {
                    switch (processCTRL)
                    {
                        case "Y":
                            processSWCT = false;
                            break;

                        case "N":
                            processSWCT = false;
                            allctrl = false;
                            break;

                        default:
                            Console.WriteLine("Please input Y or N.");
                            break;
                    }
                }
            }
        }
        static bool IsValidSequence(string halfDNASequence)
        {
            foreach (char nucleotide in halfDNASequence)
            {
                if (!"ATCG".Contains(nucleotide))
                {
                    return false;
                }
            }
            return true;
        }
        static string ReplicateSeqeunce(string halfDNASequence)
        {
            string result = "";
            foreach (char nucleotide in halfDNASequence)
            {
                result += "TAGC"["ATCG".IndexOf(nucleotide)];
            }
            return result;
        }

    }
}