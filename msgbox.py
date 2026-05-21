import tkinter as tk



class myapps:
    def __init__(self,root:tk.Tk,title:str,text:str,backgrouds:str,foregrounds:str):
        self.root=root
        self.root.title(title)
        self.root.geometry("350x250")
        self.root.configure(background=backgrouds)
        self.label=tk.Label(background=backgrouds,foreground=foregrounds,text=text)
        self.label.pack(padx=10,pady=10)
        self.oks=tk.Button(background=backgrouds,foreground=foregrounds,text="ok",command=self.root.quit)
        self.oks.pack(padx=10,pady=10)




def show(title:str,text:str,backgrouds:str,foregrounds:str):
    root=tk.Tk()
    apps=myapps(root,title,text,backgrouds,foregrounds)
    root.mainloop()
