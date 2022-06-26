// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.



document.getElementById('submit-comment-button').addEventListener('submit', addComment);

function addComment(e) {

    // Get the value of the users comment
    const commentBody = document.getElementById('comment-body-input').value;

    // Get the list of comments
    commentList = document.querySelector('.comment-list')

    const commentOutput = `<p>${commentBody}</p>`

    CommentList.appendChild(commentOutput)


}
