using system;

namespace GitLearning;

public class PostService {
  private IPostRepository _postRepository;
  public PostService(IPostRepository postRepository){
    _postRepository = postRepository;
  }
  public string Name {get; set;}
  
  public void AddPost(Post post){
    _postRepository.Add(post);
  }
  
  public Post GetPost(Guid id){
    return new Post();
  }

  public List<Post> GetPost(){
   return new List<Post>();
  }

  public void DeletePost(){
    throw new NotImplementedException();
  }
}
