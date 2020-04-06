# 安装Git步骤

安装完成后，我们进行设置一下信息：

- 生成ssh公钥

  ```css
  ssh-keygen -t rsa -C "130307300@qq.com"
  ```

  三次回车就可以了，也可以进行设置密码，自定笃定

  ![image-20200406183447284](https://i.loli.net/2020/04/06/5KZeXj1Th8PzItR.png)

  

  去默认地址copy需要的文件：（C:\Users\13030\.ssh\）
  
  ![image-20200406192351519](https://i.loli.net/2020/04/06/y4eKXNjx3qO5LTr.png)
  
  
  
  打开后进行复制里面的内容，去GitHub里面粘贴添加。
  
  ![image-20200406192442691](https://i.loli.net/2020/04/06/9puRKqJNjPEFabW.png)
  
  
  
  增加完成后我们需要进行测试一下：
  
  ```
  ssh -T git@github.com
  ```
  
  
  
  第一次连接我们需要验证一下填写yes并连接账户：
  
  ![image-20200406192812979](https://i.loli.net/2020/04/06/kMtYwBifxNgHWqp.png)
  
  ![image-20200406195146244](upload/image-20200406195146244.png)
  
  这时候本地需要创建一个本地仓库：

```
git init
```

使git和GitHub连接：

```sh
git add 文件名   //更新README文件
git commit -m '需要填写的备注' //提交更新，并注释信息“XXX” ！！！ 修改code的关键
git remote add origin git@github.com:lushaogen/lushaogen.git //连接远程github项目  
git push -u origin master   //将本地项目更新到github项目上去 ,更新+修改
git config --global user.name "lushaogen"
git config --global user.email "130307300@qq.com"
```
