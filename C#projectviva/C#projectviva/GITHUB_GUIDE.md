# GitHub Guide — how our team of 8 works together

This is the **simple, step-by-step** way our 8 members work on the project at the same time
without overwriting each other. Read it once. The golden rule: **only edit your own folder,
on your own branch.**

There are two ways to use Git. Pick whichever you like — they do the same thing:
- **A) Inside Visual Studio** (buttons, no typing) — easiest for most members.
- **B) Command line** (`git ...`) — for whoever set up the repo / is comfortable typing.

---

## 0. One-time setup (each member, once)

1. Make a free account at **https://github.com** and tell the team lead your username.
2. The team lead **invites you** to the private repository (GitHub → repo → Settings →
   Collaborators → add your username). Accept the email invite.
3. Install **Visual Studio 2022** (it includes Git and SQL Server LocalDB).
4. First time you push, Visual Studio asks you to **sign in to GitHub** — just sign in.

---

## 1. Get the project (clone) — once

**In Visual Studio:** Start window → **Clone a repository** → paste the repo URL the lead gives
you (e.g. `https://github.com/<lead-username>/TeaEstateManagementSystem.git`) → **Clone**.

**Command line:**
```bash
git clone https://github.com/<lead-username>/TeaEstateManagementSystem.git
cd TeaEstateManagementSystem
```

Then open `TeaEstateManagementSystem.sln` and press **F5** to check it runs.

---

## 2. Make YOUR branch — once

A branch is your own safe copy. Your branch name is in `TEAM_TASKS.md`
(e.g. Member 04 → `member-04-sections`).

**In Visual Studio:** bottom-right corner shows the current branch (`main`). Click it →
**New Branch** → type your branch name → **Create**. Make sure "based on `main`" is ticked.

**Command line:**
```bash
git checkout main
git pull                       # get the latest
git checkout -b member-04-sections
```

---

## 3. The daily routine (every time you work)

### Step A — get the latest first
Always start by pulling the newest `main` so you have everyone's latest work.

**Visual Studio:** Git menu → **Pull**.
**Command line:**
```bash
git checkout main
git pull
git checkout member-04-sections
git merge main                 # bring main's updates into your branch
```

### Step B — do your work
Open the solution, work **only inside your own folder** (see `TEAM_TASKS.md`).
Double-click your form to edit it in the designer. Press **F5** to test.

### Step C — save your work (commit)
A commit is a save point with a short message.

**Visual Studio:** **Git Changes** window → type a short message
(e.g. `Add delete button to SectionForm`) → **Commit All**.
**Command line:**
```bash
git add .
git commit -m "Add delete button to SectionForm"
```

### Step D — send it to GitHub (push)
**Visual Studio:** click **Push** (top of the Git Changes window).
**Command line:**
```bash
git push -u origin member-04-sections     # first push
git push                                  # every time after
```

### Step E — merge into main (Pull Request)
When your part works:
1. Go to the repo on **github.com** → it shows **"Compare & pull request"** → click it.
2. Title it (e.g. *"Member 04 — Sections module done"*) → **Create pull request**.
3. The team lead reviews and clicks **Merge**. Your work is now in `main` for everyone.

---

## 4. Golden rules (memorise these)

| ✅ Do | ❌ Don't |
|------|---------|
| Edit only **your own folder** | Edit another member's folder, `Program.cs`, or the `.csproj` |
| **Pull** before you start working | Start working on a stale copy |
| Commit small, with clear messages | Wait a week then commit everything at once |
| Push your branch often | Push straight to `main` |
| Keep the form **class names** as in `TEAM_TASKS.md` | Rename `WorkerForm`, `SectionForm`, etc. |

---

## 5. Common questions

**"It says merge conflict!"** — Two people changed the same lines. This is rare if everyone
stays in their own folder. If it happens: in Visual Studio the **Git** menu → conflicts are
listed; click each file, choose **Take Current** / **Take Incoming** / keep both, then commit.
If unsure, ask the team lead before clicking.

**"Do I commit the `bin/` and `obj/` folders?"** — No. They are build output and are already
ignored by `.gitignore`. Git won't show them — that's correct.

**"The database — do I need to set it up?"** — No. Just press F5. The app creates the
`TeaEstateDB` database in SQL Server LocalDB on first run.

**"Two of us want to test at once."** — Fine. You each run the app on your own PC; you share
the *code* through GitHub, not the running database.

---

## 6. Quick command cheat-sheet

```bash
git pull                       # get latest
git checkout -b my-branch      # make my branch (first time)
git checkout my-branch         # switch to my branch
git add .                      # stage my changes
git commit -m "message"        # save a checkpoint
git push                       # upload my branch to GitHub
git status                     # what changed?
git log --oneline              # recent history
```
