using System;

class Program
{
    static void Main(string[] args)
    {
        // Create videos
        Video v1 = new Video("Una (muy) breve introducción a la Música Clásica", "Jaime Altozano", 873);
        Video v2 = new Video("¿Por qué no se cayó Notre-Dame? Arquitecta lo EXPLICA", "Ter", 936);
        Video v3 = new Video("Las medusas son anteriores a los dinosaurios. ¿Cómo han sobrevivido tanto tiempo?", "TED-Ed", 325);

        // Add comments
        v1.AddComment(new Comment("@vanessa-98", "En momentos como este, agradezco haber nacido en la época del internet."));
        v1.AddComment(new Comment("@marianalax", "Bach... ayer tuve el inmenso placer de encontrar la partitura del Ave María. ¡Qué placer!"));
        v1.AddComment(new Comment("@athenas_dev", "El destino llamando a la puerta, me hizo causar escalofrios. Siempre senti que el romanticismo era un mar de emociones "));
        v1.AddComment(new Comment("@deniseesen", "Como una loca apasionada de la música clásica y sus diferentes épocas. Una genialidad."));

        v2.AddComment(new Comment("@nathaliacuenca234", "Confieso que puedo ver este video 10 veces y las 10 veces me sigue pareciendo fascinante"));
        v2.AddComment(new Comment("@lobitoguz", "La arquitectura gótica siempre me pareció llamativa, hermosa, refinada, el verla era un algo maravilloso."));
        v2.AddComment(new Comment("@zafiro56", "Yo: Mira, un vídeo de Ter que solo he visto 6 veces, veámoslo 11 veces más."));

        v3.AddComment(new Comment("@truongphan", "El secreto de las medusas para la inmortalidad: ¡manténgase hidratado!"));
        v3.AddComment(new Comment("@Indicental104", "La muerte viene llamando a la puerta. Medusas: sostén mis nematocistos"));
        v3.AddComment(new Comment("@adriancreates3086", "My only question is why don't we have more scientists studying these fascinating creatures?"));
        v3.AddComment(new Comment("@catiadams23", "Jellyfish are my favorite animals now. They're so cool!"));

        // Save to a list
        List<Video> videos = new List<Video>
        {
            v1, v2, v3
        };

        foreach (Video video in videos)
        {
            Console.WriteLine(video.GetDisplayText());
            // Add a divider line (I decided to do some research before put a lot of "------")
            Console.WriteLine(new string('-', 50));
        }
    }
}